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
        public Resoconto()
        {
            InitializeComponent();
        }

        bool Save(string path)
        {
            File.AppendAllText(path, String.Format("Tempo [ms];Forza [Kg];Media[Kg]\n;;{0:0.00}", Math.Round(Session.SessionInstance.Average, 2)));

            foreach (double[] val in Session.SessionInstance.Values)
                File.AppendAllText(path, Math.Round(val[0] / 1000, 2) + ";" + val[1] + Environment.NewLine);
            return true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFile.FileName))
                        File.Delete(saveFile.FileName);

                    Save(saveFile.FileName);
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

        private void Resoconto_Load(object sender, EventArgs e)
        {
            Owner.Enabled = false;
            maxVal.Text = Session.SessionInstance.Max.ToString();
            avgVal.Text = Session.SessionInstance.Average.ToString();

            timer.Text = Session.SessionInstance.GetTime();

            //chart1.ChartAreas[0].AxisY.Maximum = max + 3; //da mettere if
            //chart1.ChartAreas[0].AxisY.Minimum = min - 3;

            foreach (var item in Session.SessionInstance.Values)
            {
                chart1.Series[0].Points.AddXY(item[0] / 1000, item[1]);
            }

            //chart1.Titles[0].Text = Convert.ToString(SessionMode)Session.SessionInstance.Mode)));

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

        private void Resoconto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }
    }
}
