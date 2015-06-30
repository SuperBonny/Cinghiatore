using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Drawing;
using System.Threading;

namespace Cinghiatore
{
    public partial class Form1 : Form
    {
        Stopwatch watch = new Stopwatch();

        public  SerialPort arduino = new SerialPort();
        List<Tuple<double, double>> values = new List<Tuple<double, double>>();
        double max = 0;
        double min = 0;

        bool saved = false;
        public  int esercizi = 0;

        public static Color chartColor = Color.FromArgb(30, 144, 255);
        public static Color inRangeColor = Color.FromArgb(40, 143, 43);
        public static Color outRangeColor = Color.FromArgb(200, 20, 20);

        public int secondi = 0;
        public  int minuti = 0;
         
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
                if (e.Value.Item2 > -1.5 && e.Value.Item2 < 1.5)
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


            chart1.Series[0].Points.AddXY(e.Value.Item1 / 1000, e.Value.Item2);

            time.Text = Session.SessionInstance.tempo();

            curVal.Text = Convert.ToString(e.Value.Item2);

           //chart1.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(Session.SessionInstance.maxVal() + 3);
           //chart1.ChartAreas[0].AxisY.Minimum = Convert.ToInt32(chart1.Series[0].Points[chart1.Series[0].Points.FindMinByValue()].YValues - 3);

            maxVal.Text = Session.SessionInstance.maxVal().ToString();
             
        }

        

        private void startBtn_Click(object sender, EventArgs e)
        {
            //Session.SessionInstance.Mode = (int)SessionMode.Libero;

            if (Session.SessionInstance.Started())
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
            if (Session.SessionInstance.Started())
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

            Form Form3 = new Resoconto(Session.SessionInstance.minVal(), Session.SessionInstance.maxVal(), Session.SessionInstance.average(), Session.SessionInstance.tempo(), Session.SessionInstance.values);
            Form3.Show();
        }

        private void tareBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Session.SessionInstance.Tare();
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
