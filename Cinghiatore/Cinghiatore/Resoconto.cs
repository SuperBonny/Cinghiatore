using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinghiatore
{
    public partial class Resoconto : Form
    {
        List<Tuple<double, double>> values = new List<Tuple<double, double>>();
        double avg, max, min;
        string time;

        public Resoconto(double minV ,double maxV, double avgV, string timeV, List<Tuple<double,double>> value)
        {
            InitializeComponent();
            max = maxV;
            min = minV;
            avg = avgV;
            time = timeV;
            maxVal.Text = max.ToString();
            avgVal.Text = avgV.ToString();

            if (Session.SessionInstance.IsCountDown)
                timer.Text = String.Format("{0:00}:{1:00}", Session.SessionInstance.Time.Minutes, Session.SessionInstance.Time.Seconds);
            else
                timer.Text = time;

            values = value;

            //chart1.ChartAreas[0].AxisY.Maximum = max + 3; //da mettere if
            //chart1.ChartAreas[0].AxisY.Minimum = min - 3;

            foreach (var item in values)
            {
                chart1.Series[0].Points.AddXY(item.Item1 / 1000, item.Item2);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFile.FileName))
                        File.Delete(saveFile.FileName);
                    
                    Session.SessionInstance.Save(saveFile.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Session.SessionInstance.Reset();
            this.Close();
        }

        private void Resoconto_Load(object sender, EventArgs e)
        {
            switch (Session.SessionInstance.Mode)
            {
                case 0:
                    chart1.Titles[0].Text = "Libero";
                    break;
                case 1:
                    chart1.Titles[0].Text = "Massimale";
                    break;
                case 2:
                    chart1.Titles[0].Text = "Resistenza";
                    break;
            }
        }
    }
}
