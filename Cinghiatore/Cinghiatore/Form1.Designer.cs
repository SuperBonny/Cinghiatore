namespace Cinghiatore
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.curVal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.time = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rstBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maxVal = new System.Windows.Forms.Label();
            this.tareBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(1155, 3);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(128, 157);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.curVal);
            this.groupBox1.Location = new System.Drawing.Point(130, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valore Corrente [Kg]";
            // 
            // curVal
            // 
            this.curVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curVal.Font = new System.Drawing.Font("Impact", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curVal.Location = new System.Drawing.Point(3, 22);
            this.curVal.Name = "curVal";
            this.curVal.Size = new System.Drawing.Size(207, 113);
            this.curVal.TabIndex = 22;
            this.curVal.Text = "-00";
            this.curVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.time);
            this.groupBox2.Location = new System.Drawing.Point(350, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 138);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tempo";
            // 
            // time
            // 
            this.time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time.Font = new System.Drawing.Font("Impact", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(3, 22);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(276, 113);
            this.time.TabIndex = 23;
            this.time.Text = "00:00";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rstBtn);
            this.panel1.Controls.Add(this.settingsBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.tareBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 619);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 163);
            this.panel1.TabIndex = 6;
            // 
            // rstBtn
            // 
            this.rstBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rstBtn.Location = new System.Drawing.Point(879, 83);
            this.rstBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rstBtn.Name = "rstBtn";
            this.rstBtn.Size = new System.Drawing.Size(112, 75);
            this.rstBtn.TabIndex = 24;
            this.rstBtn.Text = "Reset";
            this.rstBtn.UseVisualStyleBackColor = true;
            this.rstBtn.Click += new System.EventHandler(this.rstBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.Location = new System.Drawing.Point(879, 8);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(112, 65);
            this.settingsBtn.TabIndex = 23;
            this.settingsBtn.Text = "Impostazioni";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(1022, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 157);
            this.button1.TabIndex = 22;
            this.button1.Text = "Fine Sessione";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.maxVal);
            this.groupBox3.Location = new System.Drawing.Point(638, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 138);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valore Massimo [Kg]";
            // 
            // maxVal
            // 
            this.maxVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxVal.Font = new System.Drawing.Font("Impact", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxVal.Location = new System.Drawing.Point(3, 22);
            this.maxVal.Name = "maxVal";
            this.maxVal.Size = new System.Drawing.Size(207, 113);
            this.maxVal.TabIndex = 23;
            this.maxVal.Text = "00";
            this.maxVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tareBtn
            // 
            this.tareBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tareBtn.Location = new System.Drawing.Point(3, 3);
            this.tareBtn.Name = "tareBtn";
            this.tareBtn.Size = new System.Drawing.Size(128, 157);
            this.tareBtn.TabIndex = 6;
            this.tareBtn.Text = "Tara";
            this.tareBtn.UseVisualStyleBackColor = true;
            this.tareBtn.Click += new System.EventHandler(this.tareBtn_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1284, 619);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 782);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Cinghiatore";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tareBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label curVal;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label maxVal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button rstBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

