﻿using System;
using System.IO;
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
            File.WriteAllText(path, "Tempo [s];Forza [Kg];Media [Kg]" + Environment.NewLine + ";;" + Math.Round(Session.SessionInstance.Average, 2) + Environment.NewLine);
            foreach (var item in Session.SessionInstance.Values)
            {
                File.AppendAllText(path, Math.Round(item[0] / 1000, 2) + ";" + item[1] + Environment.NewLine); //!!!da debuggare!!!
            }
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
            avgVal.Text = Math.Round(Session.SessionInstance.Average, 2).ToString();

            if (Session.SessionInstance.IsCountDown)
                timer.Text = Session.SessionInstance.GetElapsed();
            else
                timer.Text = Session.SessionInstance.GetTime();


            switch ((int)Session.SessionInstance.Mode)
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

            for (int i = 0; i < Session.SessionInstance.Values.Count; i++)
            {
                double avg = 0;
                for (int g = 0; g < i; g++)
                {
                    avg += Session.SessionInstance.Values[g][1];
                }
                chart1.Series[0].Points.AddXY(Session.SessionInstance.Values[i][0] / 1000, Session.SessionInstance.Values[i][1]);
                chart1.Series[1].Points.AddXY(Session.SessionInstance.Values[i][0] / 1000, avg / i);

                chart1.ChartAreas[0].AxisY.Maximum = Session.SessionInstance.Max + 1;
                chart1.ChartAreas[0].AxisY.Minimum = Session.SessionInstance.Min - 1;
                
            }
        }

        private void Resoconto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }
    }
}
