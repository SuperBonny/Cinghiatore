﻿using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;

namespace Cinghiatore
{
    public partial class Form1 : Form
    {
        GraphPane panel = new GraphPane();

        public int MaxOffTime { get; set; }
        Stopwatch off;
        public  SerialPort arduino = new SerialPort();

        Color chartColor, inRangeColor, outRangeColor, limitColor;
        double offset;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            zedGraphControl1.GraphPane.CurveList.Add(new CurveItem())
            Session.SessionInstance.NewData += Session_NewData;
            Session.SessionInstance.RunningChanged += SessionInstance_RunningChanged;
        }

        void SessionInstance_RunningChanged(object sender, EventArgs e)
        {
            if (Session.SessionInstance.IsStarted)
                startBtn.Text = "Stop";
            else
                startBtn.Text = "Start";
        }

        void Session_NewData(object sender, SerialEventArgs e)
        {
            try
            {
                if (Session.SessionInstance.Mode == SessionMode.Resistenza)
                {
                    if (e.Value[1] > -offset && e.Value[1] < offset)
                    {
                        if (off.IsRunning)
                            off.Reset();
                        chart1.Series[0].Color = inRangeColor;
                    }
                    else
                    {
                        if (!off.IsRunning)
                            off.Start();
                        chart1.Series[0].Color = outRangeColor;

                        if (off.ElapsedMilliseconds >= MaxOffTime)
                        {
                            if (Session.SessionInstance.IsStarted)
                            {
                                Session.SessionInstance.Stop();
                                EndSession();
                            }
                        }
                    }
                }
                else if (Session.SessionInstance.Mode == SessionMode.Massimale)
                    chart1.Series[0].Color = chartColor;
                else if (Session.SessionInstance.Mode == SessionMode.Libero)
                    chart1.Series[0].Color = chartColor;

                chart1.ChartAreas[0].AxisY.Maximum = Session.SessionInstance.Max + 2;
                chart1.ChartAreas[0].AxisY.Minimum = Session.SessionInstance.Min - 2;


                //line.AddPoint(e.Value[0] / 1000, e.Value[1]);// = panel.AddCurve(null, p, chartColor);
                //chart1.Series[0].Points.AddXY(e.Value[0] / 1000, e.Value[1]); //TASK!!

                zedGraphControl1.GraphPane.CurveList[0].AddPoint(e.Value[0] / 1000, e.Value[1]);

                time.Text = Session.SessionInstance.GetTime();
                
                curVal.Text = Convert.ToString(e.Value[1]);

                maxVal.Text = Session.SessionInstance.Max.ToString();

                zedGraphControl1.AxisChange(); 
            }
            catch(Exception ex)
            {
                ShowError(ex);
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (Session.SessionInstance.IsStarted)
                Session.SessionInstance.Stop();
            else
            {
                if (Session.SessionInstance.Mode == SessionMode.Resistenza)
                {
                    StripLine str1 = new StripLine();
                    str1.Interval = 0;
                    str1.IntervalOffset = offset;
                    str1.StripWidth = 0.1;
                    str1.BackColor = limitColor;
                    chart1.ChartAreas[0].AxisY.StripLines.Add(str1);
                    StripLine str2 = new StripLine();
                    str2.Interval = 0;
                    str2.IntervalOffset = -offset;
                    str2.StripWidth = 0.1;
                    str2.BackColor = limitColor;
                    chart1.ChartAreas[0].AxisY.StripLines.Add(str2);
                }
                try
                {
                    Session.SessionInstance.Read();
                }
                catch (InvalidOperationException ex)
                {
                    ShowError(ex);
                }

                Session.SessionInstance.Start();
                startBtn.Text = "Stop";
                button1.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Session.SessionInstance.NewData += Session_NewData;
            Impostazioni set = new Impostazioni();
            set.ShowInTaskbar = false;
            set.ShowDialog(this);

            off = new Stopwatch();
            chartColor = Properties.Settings.Default.ChartColor;
            inRangeColor=Properties.Settings.Default.InColor;
            outRangeColor=Properties.Settings.Default.OutColor;
            limitColor = Properties.Settings.Default.LimitColor;
            offset=Properties.Settings.Default.Offset;
            MaxOffTime = Properties.Settings.Default.OffTime;
            Session.SessionInstance.Interval = Properties.Settings.Default.Interval;

            Session.SessionInstance.Connect();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Session.SessionInstance.Stop();
            Impostazioni set = new Impostazioni();
            set.ShowInTaskbar = false;
            set.Owner = this;
            set.Show();
            Reset();
        }

        void Reset()
        {
            Session.SessionInstance.Reset();
            chart1.Series[0].Points.Clear();
            button1.Enabled = false;
            curVal.ResetText();
            time.ResetText();

        }

        void EndSession(string message=default(string))
        {
            Session.SessionInstance.Stop();
            Resoconto res = new Resoconto();
            res.ShowInTaskbar = false;
            res.ShowDialog(this);
        }

        private void tareBtn_Click(object sender, EventArgs e)
        {
            if (Session.SessionInstance.IsStarted)
            {
                try
                {
                    Session.SessionInstance.Stop();
                    Session.SessionInstance.Tare();
                    chart1.Series[0].Points.Clear();
                    Session.SessionInstance.Start();
                    try
                    {
                        Session.SessionInstance.Read();
                    }
                    catch (InvalidOperationException ex)
                    {
                        ShowError(ex);
                    }
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
            else
            {
                try
                {
                    Session.SessionInstance.Tare();
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        private void rstBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void ShowError(Exception e)
        {
            MessageBox.Show(e.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndSession();
        }
    }
}
