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
        public Impostazioni()
        {
            InitializeComponent();
        }
        
        public static int tabIndex = 0;
        private void Impostazioni_Load(object sender, EventArgs e)
        {
            ReloadSerial();

            if (serialCombo.Items.IndexOf(Session.SessionInstance.Port) == 0)
                serialCombo.SelectedItem = Session.SessionInstance.Port;
            else
                serialCombo.SelectedIndex = 0;

            if (baudCombo.Items.IndexOf(Convert.ToString(Session.SessionInstance.BaudRate)) != 0)
            {
                baudCombo.SelectedItem = Convert.ToString(Session.SessionInstance.BaudRate);
            }
            else
                baudCombo.SelectedIndex = 0;
            
            chartColorBox.BackColor = Form1.chartColor;
            outRangeColorBox.BackColor = Form1.outRangeColor;
            inRangeColorBox.BackColor = Form1.inRangeColor;
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
                if (serialCombo.Text != Session.SessionInstance.Port || baudCombo.Text != Convert.ToString(Session.SessionInstance.BaudRate))
                    Session.SessionInstance.Connect(serialCombo.Text, Convert.ToInt32(baudCombo.Text));

                if (eserciziBox.SelectedIndex != Session.SessionInstance.Mode)
                    Session.SessionInstance.Mode = eserciziBox.SelectedIndex;

                if (minuti.Value > 0 || secondi.Value > 0)
                {
                    Session.SessionInstance.IsCountDown = true;
                    Session.SessionInstance.Time = new TimeSpan(0, Convert.ToInt32(minuti.Value), Convert.ToInt32(secondi.Value));
                }
                else
                {
                    Session.SessionInstance.IsCountDown = false;
                    Session.SessionInstance.Time = new TimeSpan(0, int.MaxValue, int.MaxValue);
                }
                Session.SessionInstance.Interval = intervalSel.Value;
                tabIndex = 0;
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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{

                if (colorDialog1.ShowDialog() == DialogResult.OK)
                    Form1.chartColor = colorDialog1.Color;

                chartColorBox.BackColor = Form1.chartColor;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void intervalSel_Scroll(object sender, EventArgs e)
        {
            intervalLbl.Text = "Intervallo di acquisizione: " + intervalSel.Value + "ms";
        }
    }
}
