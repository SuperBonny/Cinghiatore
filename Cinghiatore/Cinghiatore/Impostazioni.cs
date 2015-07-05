using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinghiatore
{
    public partial class Impostazioni : Form
    {
        int min, sec, offSec;
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

        int offSecond
        {
            get { return offSec; }
            set{
                offSec = value;
                offSecLbl.Text = offSec.ToString();

                if(offSec == 0)
                    offSecDecr.Enabled = false;
                else
                    offSecDecr.Enabled = true;

                if (offSec == 20)
                    offSecIncr.Enabled = false;
                else
                    offSecIncr.Enabled = true;
            }
        }

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
            baudCombo.SelectedItem = Session.SessionInstance.BaudRate.ToString();

            ReloadSerial();
            if(Session.SessionInstance.Port!=null)
                serialCombo.SelectedItem = Session.SessionInstance.Port;
        }

        void ReloadSerial()
        {
            serialCombo.Items.Clear();
            foreach (string item in AutodetectArduinoPort())
                serialCombo.Items.Add(item);
            serialCombo.SelectedIndex = serialCombo.Items.Count - 1;
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

                Session.SessionInstance.Port = serialCombo.Text;
                Session.SessionInstance.BaudRate = Convert.ToInt32(baudCombo.Text);

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
                chartColorBox.BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                outRangeColorBox.BackColor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                inRangeColorBox.BackColor = colorDialog1.Color;
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

        string[] AutodetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                List<string> coms = new List<string>();
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    if (desc.Contains("Arduino"))
                        coms.Add(deviceId);
                }
                return coms.ToArray();
            }
            catch (ManagementException e)
            {
                MessageBox.Show(e.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private void exerciseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (exerciseBox.SelectedIndex == 2)
            {
                groupBox2.Enabled = true;
                groupBox6.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
                groupBox6.Enabled = false;
            }    
        }

        private void offIncr_Click_1(object sender, EventArgs e)
        {
            if (off < 10)
                Offset += 0.5;
        }

        private void offDecr_Click_1(object sender, EventArgs e)
        {
            if (off > 0)
                Offset -= 0.5;
        }

        private void offSecIncr_Click(object sender, EventArgs e)
        {
            if (offSec < 20)
                offSecond++;
        }

        private void offSecDecr_Click(object sender, EventArgs e)
        {
            if (offSec > 0)
                offSecond--;
        }


    }
}
