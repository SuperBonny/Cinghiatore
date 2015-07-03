namespace Cinghiatore
{
    partial class Impostazioni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serialCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baudCombo = new System.Windows.Forms.ComboBox();
            this.abortBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.okBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secondi = new System.Windows.Forms.NumericUpDown();
            this.minuti = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eserciziBox = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inRangeColorBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.outRangeColorBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.chartColorBox = new System.Windows.Forms.PictureBox();
            this.intervalSel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuti)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inRangeColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outRangeColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalSel)).BeginInit();
            this.SuspendLayout();
            // 
            // serialCombo
            // 
            this.serialCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialCombo.FormattingEnabled = true;
            this.serialCombo.Location = new System.Drawing.Point(9, 58);
            this.serialCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serialCombo.Name = "serialCombo";
            this.serialCombo.Size = new System.Drawing.Size(140, 28);
            this.serialCombo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.baudCombo);
            this.groupBox1.Controls.Add(this.serialCombo);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(292, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seriale";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Cinghiatore.Properties.Resources.Refresh_icon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(189, 49);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 49);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Porta Seriale";
            // 
            // baudCombo
            // 
            this.baudCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudCombo.FormattingEnabled = true;
            this.baudCombo.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudCombo.Location = new System.Drawing.Point(9, 145);
            this.baudCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.baudCombo.Name = "baudCombo";
            this.baudCombo.Size = new System.Drawing.Size(140, 28);
            this.baudCombo.TabIndex = 1;
            // 
            // abortBtn
            // 
            this.abortBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.abortBtn.Location = new System.Drawing.Point(0, 0);
            this.abortBtn.Name = "abortBtn";
            this.abortBtn.Size = new System.Drawing.Size(142, 142);
            this.abortBtn.TabIndex = 7;
            this.abortBtn.Text = "Annulla";
            this.abortBtn.UseVisualStyleBackColor = true;
            this.abortBtn.Click += new System.EventHandler(this.abortBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.okBtn);
            this.panel1.Controls.Add(this.abortBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 228);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 142);
            this.panel1.TabIndex = 8;
            // 
            // okBtn
            // 
            this.okBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.okBtn.Location = new System.Drawing.Point(442, 0);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(142, 142);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.secondi);
            this.groupBox2.Controls.Add(this.minuti);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.eserciziBox);
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(426, 128);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generali";
            // 
            // secondi
            // 
            this.secondi.Location = new System.Drawing.Point(338, 72);
            this.secondi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondi.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondi.Name = "secondi";
            this.secondi.Size = new System.Drawing.Size(58, 26);
            this.secondi.TabIndex = 4;
            // 
            // minuti
            // 
            this.minuti.Location = new System.Drawing.Point(271, 72);
            this.minuti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minuti.Name = "minuti";
            this.minuti.Size = new System.Drawing.Size(58, 26);
            this.minuti.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Timer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo di Esercizio";
            // 
            // eserciziBox
            // 
            this.eserciziBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eserciziBox.FormattingEnabled = true;
            this.eserciziBox.Items.AddRange(new object[] {
            "Libero",
            "Resistenza",
            "Massimale"});
            this.eserciziBox.Location = new System.Drawing.Point(9, 63);
            this.eserciziBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eserciziBox.Name = "eserciziBox";
            this.eserciziBox.Size = new System.Drawing.Size(162, 28);
            this.eserciziBox.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 226);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(817, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nerd";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(572, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Esercizi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.intervalSel);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(572, 180);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generali";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.inRangeColorBox);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.outRangeColorBox);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.chartColorBox);
            this.groupBox3.Location = new System.Drawing.Point(9, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(199, 163);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colori";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Grafico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inRangeColorBox
            // 
            this.inRangeColorBox.Location = new System.Drawing.Point(152, 119);
            this.inRangeColorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inRangeColorBox.Name = "inRangeColorBox";
            this.inRangeColorBox.Size = new System.Drawing.Size(35, 35);
            this.inRangeColorBox.TabIndex = 9;
            this.inRangeColorBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 74);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Out ofRange";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // outRangeColorBox
            // 
            this.outRangeColorBox.Location = new System.Drawing.Point(152, 74);
            this.outRangeColorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outRangeColorBox.Name = "outRangeColorBox";
            this.outRangeColorBox.Size = new System.Drawing.Size(35, 35);
            this.outRangeColorBox.TabIndex = 8;
            this.outRangeColorBox.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 119);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "inRange";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chartColorBox
            // 
            this.chartColorBox.BackColor = System.Drawing.Color.Transparent;
            this.chartColorBox.Location = new System.Drawing.Point(152, 29);
            this.chartColorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartColorBox.Name = "chartColorBox";
            this.chartColorBox.Size = new System.Drawing.Size(35, 35);
            this.chartColorBox.TabIndex = 7;
            this.chartColorBox.TabStop = false;
            // 
            // intervalSel
            // 
            this.intervalSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.intervalSel.Location = new System.Drawing.Point(444, 39);
            this.intervalSel.Name = "intervalSel";
            this.intervalSel.Size = new System.Drawing.Size(120, 26);
            this.intervalSel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Intervallo di acquisizione [ms]";
            // 
            // Impostazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 370);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Impostazioni";
            this.Text = "Impostazioni";
            this.Load += new System.EventHandler(this.Impostazioni_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuti)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inRangeColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outRangeColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalSel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox serialCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox baudCombo;
        private System.Windows.Forms.Button abortBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown secondi;
        private System.Windows.Forms.NumericUpDown minuti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox eserciziBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox inRangeColorBox;
        private System.Windows.Forms.PictureBox outRangeColorBox;
        private System.Windows.Forms.PictureBox chartColorBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.NumericUpDown intervalSel;
        private System.Windows.Forms.Label label5;
    }
}