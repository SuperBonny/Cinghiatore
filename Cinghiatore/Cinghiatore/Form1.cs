using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cinghiatore
{
    public partial class Form1 : Form
    {
        Stopwatch watch = new Stopwatch();

        public  SerialPort arduino = new SerialPort();
        List<Tuple<double, double>> values = new List<Tuple<double, double>>();

        public static Color chartColor = Color.FromArgb(30, 144, 255);
        public static Color inRangeColor = Color.FromArgb(40, 143, 43);
        public static Color outRangeColor = Color.FromArgb(200, 20, 20);

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            Session.SessionInstance.NewData += Session_NewData;
        }

        void Session_NewData(object sender, SerialEventArgs e)
        {
            if (Session.SessionInstance.Mode == 1)
            {
                if (e.Value[1] > -1.5 && e.Value[1] < 1.5)
                {
                    chart1.Series[0].Color = inRangeColor;
                }
                else
                {
                    chart1.Series[0].Color = outRangeColor;
                }

            }
            else if (Session.SessionInstance.Mode == 2)
            {
                chart1.Series[0].Color = chartColor;

            }
            else if (Session.SessionInstance.Mode == 0)
            {
                chart1.Series[0].Color = chartColor;
            }

            Task.Factory.StartNew(() => chart1.Series[0].Points.AddXY(e.Value[0] / 1000, e.Value[1]));

            time.Text = Session.SessionInstance.GetTime();

            curVal.Text = Convert.ToString(e.Value[1]);

            maxVal.Text = Session.SessionInstance.Max.ToString();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (Session.SessionInstance.IsStarted)
            {
                Session.SessionInstance.Stop();
                startBtn.Text = "Start";
                button1.Enabled = false;
            }
            else
            {
                Session.SessionInstance.Read();
                Session.SessionInstance.Start();
                startBtn.Text = "Stop";
                button1.Enabled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Impostazioni set = new Impostazioni();
            set.ShowInTaskbar = false;
            set.ShowDialog(this);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Session.SessionInstance.Stop();
            Impostazioni set = new Impostazioni();
            set.ShowInTaskbar = false;
            set.Owner = this;
            set.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session.SessionInstance.Stop();
            Resoconto res = new Resoconto();
            res.ShowInTaskbar = false;
            res.Owner = this;
            res.Show();
        }

        private void tareBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Session.SessionInstance.Tare();
                chart1.Series[0].Points.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rstBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Session.SessionInstance.Reset();
                chart1.Series[0].Points.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
