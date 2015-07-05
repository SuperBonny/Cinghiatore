using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Cinghiatore
{
    public partial class Impostazioni : Form
    {
        int min, sec;
        double off;
        int Minutes { get { return min; } 
            set { 
                min = value; 
                minLbl.Text = min.ToString();
                if (min == 0)
                    minDecr.Enabled = false;
                else
                    minDecr.Enabled = true;
                if (min == 59)
                {
                    minIncr.Enabled = false;
                    if (sec == 59)
                        secIncr.Enabled = false;
                    else
                        secIncr.Enabled = true;
                }
                else
                    minIncr.Enabled = true;
            } }
        int Seconds { get { return sec; } 
            set { 
                sec = value; 
                secLbl.Text = sec.ToString();
                if (sec == 0)
                    secDecr.Enabled = false;
                else
                    secDecr.Enabled = true;
                if (min == 59 && sec == 59)
                    secIncr.Enabled = false;
                else
                    secIncr.Enabled = true;
            } }

        double Offset { get { return off; }
            set
            {
                off = value;
                OffLbl.Text = off.ToString();
                if (off == 0)
                    offDecr.Enabled = false;
                else
                    offDecr.Enabled = true;

                if (off == 10)
                    offIncr.Enabled = false;
                else
                    offIncr.Enabled = true;
            }
        }

        public Impostazioni()
        {
            InitializeComponent();
        }

        private void Impostazioni_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
            ReloadSerial();

            if (Session.SessionInstance.IsCountDown)
            {
                Minutes = Session.SessionInstance.Time.Minutes;
                Seconds = Session.SessionInstance.Time.Seconds;
            }
            else
            {
                Minutes = 0;
                Seconds = 0;
            }

            intervalSel.Value = (int)Properties.Settings.Default.Interval;
            chartColorBox.BackColor = Properties.Settings.Default.ChartColor;
            outRangeColorBox.BackColor = Properties.Settings.Default.OutColor;
            inRangeColorBox.BackColor = Properties.Settings.Default.InColor;
            Offset = Properties.Settings.Default.Offset;
            outRangeColorBox.BackColor = Properties.Settings.Default.OutColor;
            inRangeColorBox.BackColor = Properties.Settings.Default.InColor;

            exerciseBox.SelectedIndex = (int)Session.SessionInstance.Mode;
            serialCombo.SelectedItem = Session.SessionInstance.Port;
            baudCombo.SelectedItem = Session.SessionInstance.BaudRate.ToString();
        }

        void ReloadSerial()
        {
            serialCombo.Items.Clear();
            foreach (var item in SerialPort.GetPortNames())
                serialCombo.Items.Add(item);
            serialCombo.SelectedIndex = 0;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Session.SessionInstance.Mode = (SessionMode)exerciseBox.SelectedIndex;

                if (Minutes > 0 || Seconds > 0)
                {
                    Session.SessionInstance.IsCountDown = true;
                    Session.SessionInstance.Time = new TimeSpan(0, Minutes, Seconds);
                }
                else
                {
                    Session.SessionInstance.IsCountDown = false;
                    Session.SessionInstance.Time = new TimeSpan(0, int.MaxValue, int.MaxValue);
                }

                Properties.Settings.Default.Offset = Convert.ToDouble(OffLbl.Text);
                Properties.Settings.Default.Interval = intervalSel.Value;
                Properties.Settings.Default.ChartColor = chartColorBox.BackColor;
                Properties.Settings.Default.OutColor = outRangeColorBox.BackColor;
                Properties.Settings.Default.InColor = inRangeColorBox.BackColor;
                Properties.Settings.Default.LimitColor = limitColorBox.BackColor;

                Session.SessionInstance.Reset();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReloadSerial();
        }

        private void abortBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Form1.chartColor = colorDialog1.Color;
            chartColorBox.BackColor = Form1.chartColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                    Form1.outRangeColor = colorDialog1.Color;
                
                outRangeColorBox.BackColor = Form1.outRangeColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                    Form1.inRangeColor = colorDialog1.Color;

                inRangeColorBox.BackColor = Form1.inRangeColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minIncr_Click(object sender, EventArgs e)
        {
            if (min < 59)
                Minutes++;
        }

        private void minDecr_Click(object sender, EventArgs e)
        {
            if (min > 0)
                Minutes--;
        }

        private void secIncr_Click(object sender, EventArgs e)
        {
            if (sec < 59)
                Seconds++;
            else
                if (min < 59)
                {
                    Minutes++;
                    Seconds = 0;
                }
        }

        private void secDecr_Click(object sender, EventArgs e)
        {
            if (Seconds > 0)
                Seconds--;
        }

        private void intervalSel_ValueChanged(object sender, EventArgs e)
        {
            intervalLabel.Text = intervalSel.Value + "ms";
        }

        private void Impostazioni_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }

        private void offIncr_Click(object sender, EventArgs e)
        {

        }

        private void offDecr_Click(object sender, EventArgs e)
        {

        }
    }
}
