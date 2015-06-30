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

        bool saved = false;

        public static Color chartColor = Color.FromArgb(30, 144, 255);
        public static Color inRangeColor = Color.FromArgb(40, 143, 43);
        public static Color outRangeColor = Color.FromArgb(200, 20, 20);

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            Session.SessionInstance.onNewData += Session_onNewData;
        }

        void Session_onNewData(object sender, SerialEventArgs e)
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

            time.Text = Session.SessionInstance.tempo();

            curVal.Text = Convert.ToString(e.Value[1]);

            //maxVal.Text = Convert.ToString(Max);//Session.SessionInstance.maxVal().ToString();
             
        }

        

        private void startBtn_Click(object sender, EventArgs e)
        {
            //Session.SessionInstance.Mode = (int)SessionMode.Libero;

            if (Session.SessionInstance.IsStarted)
            {
                Session.SessionInstance.Stop();
                startBtn.Text = "Start";
                button1.Enabled = false;
            }
            else
            {
                Session.SessionInstance.Start();
                startBtn.Text = "Stop";
                button1.Enabled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               Session.SessionInstance.Connect("COM3", 115200);
               Form Form2 = new Impostazioni();
               Impostazioni.tabIndex = 1;
               Form2.TopMost = true;
               Form2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                Form Form2 = new Impostazioni();
                Impostazioni.tabIndex = 0;
                Form2.TopMost = true;
                Form2.Show();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Session.SessionInstance.IsStarted)
            {
                var c = MessageBox.Show("Aprire le impostazioni?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (c == DialogResult.Yes)
                {
                    Session.SessionInstance.Stop();
                    Form Form2 = new Impostazioni();
                    Form2.Show();
                }
            }
            else
            {
                Form Form2 = new Impostazioni();
                Form2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session.SessionInstance.Stop();

            //Form Form3 = new Resoconto(Session.SessionInstance.minVal(), Session.SessionInstance.maxVal(), Session.SessionInstance.average(), Session.SessionInstance.tempo(), Session.SessionInstance.values);
            //Form3.Show();
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
