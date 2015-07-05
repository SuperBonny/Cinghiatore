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
            this.okBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.minDecr = new System.Windows.Forms.Button();
            this.minIncr = new System.Windows.Forms.Button();
            this.minLbl = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.secDecr = new System.Windows.Forms.Button();
            this.secIncr = new System.Windows.Forms.Button();
            this.secLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.exerciseBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.offDecr = new System.Windows.Forms.Button();
            this.offIncr = new System.Windows.Forms.Button();
            this.OffLbl = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.limitColorBox = new System.Windows.Forms.PictureBox();
            this.limitBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.inRangeColorBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.outRangeColorBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.chartColorBox = new System.Windows.Forms.PictureBox();
            this.intervalSel = new System.Windows.Forms.TrackBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inRangeColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outRangeColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalSel)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialCombo
            // 
            this.serialCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialCombo.FormattingEnabled = true;
            this.serialCombo.Location = new System.Drawing.Point(8, 48);
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
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(206, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seriale";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Cinghiatore.Properties.Resources.Refresh_icon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(156, 48);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 28);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
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
            this.baudCombo.Location = new System.Drawing.Point(8, 106);
            this.baudCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.baudCombo.Name = "baudCombo";
            this.baudCombo.Size = new System.Drawing.Size(140, 28);
            this.baudCombo.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(688, 0);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(82, 35);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 532);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.exerciseBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(766, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Esercizi";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.minDecr);
            this.groupBox4.Controls.Add(this.minIncr);
            this.groupBox4.Controls.Add(this.minLbl);
            this.groupBox4.Location = new System.Drawing.Point(414, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(100, 160);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minuti";
            // 
            // minDecr
            // 
            this.minDecr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.minDecr.Location = new System.Drawing.Point(3, 117);
            this.minDecr.Name = "minDecr";
            this.minDecr.Size = new System.Drawing.Size(94, 40);
            this.minDecr.TabIndex = 2;
            this.minDecr.Text = "-";
            this.minDecr.UseVisualStyleBackColor = true;
            this.minDecr.Click += new System.EventHandler(this.minDecr_Click);
            // 
            // minIncr
            // 
            this.minIncr.Dock = System.Windows.Forms.DockStyle.Top;
            this.minIncr.Location = new System.Drawing.Point(3, 22);
            this.minIncr.Name = "minIncr";
            this.minIncr.Size = new System.Drawing.Size(94, 40);
            this.minIncr.TabIndex = 1;
            this.minIncr.Text = "+";
            this.minIncr.UseVisualStyleBackColor = true;
            this.minIncr.Click += new System.EventHandler(this.minIncr_Click);
            // 
            // minLbl
            // 
            this.minLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLbl.Location = new System.Drawing.Point(3, 22);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(94, 135);
            this.minLbl.TabIndex = 0;
            this.minLbl.Text = "0";
            this.minLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.secDecr);
            this.groupBox5.Controls.Add(this.secIncr);
            this.groupBox5.Controls.Add(this.secLbl);
            this.groupBox5.Location = new System.Drawing.Point(542, 206);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(100, 160);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Secondi";
            // 
            // secDecr
            // 
            this.secDecr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.secDecr.Location = new System.Drawing.Point(3, 117);
            this.secDecr.Name = "secDecr";
            this.secDecr.Size = new System.Drawing.Size(94, 40);
            this.secDecr.TabIndex = 2;
            this.secDecr.Text = "-";
            this.secDecr.UseVisualStyleBackColor = true;
            this.secDecr.Click += new System.EventHandler(this.secDecr_Click);
            // 
            // secIncr
            // 
            this.secIncr.Dock = System.Windows.Forms.DockStyle.Top;
            this.secIncr.Location = new System.Drawing.Point(3, 22);
            this.secIncr.Name = "secIncr";
            this.secIncr.Size = new System.Drawing.Size(94, 40);
            this.secIncr.TabIndex = 1;
            this.secIncr.Text = "+";
            this.secIncr.UseVisualStyleBackColor = true;
            this.secIncr.Click += new System.EventHandler(this.secIncr_Click);
            // 
            // secLbl
            // 
            this.secLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLbl.Location = new System.Drawing.Point(3, 22);
            this.secLbl.Name = "secLbl";
            this.secLbl.Size = new System.Drawing.Size(94, 135);
            this.secLbl.TabIndex = 0;
            this.secLbl.Text = "0";
            this.secLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(510, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 59);
            this.label6.TabIndex = 8;
            this.label6.Text = ":";
            // 
            // exerciseBox
            // 
            this.exerciseBox.FormattingEnabled = true;
            this.exerciseBox.ItemHeight = 20;
            this.exerciseBox.Items.AddRange(new object[] {
            "Libero",
            "Massimale",
            "Resistenza"});
            this.exerciseBox.Location = new System.Drawing.Point(249, 26);
            this.exerciseBox.Name = "exerciseBox";
            this.exerciseBox.Size = new System.Drawing.Size(120, 124);
            this.exerciseBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo di Esercizio";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.intervalLabel);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.intervalSel);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(766, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generali";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.offDecr);
            this.groupBox2.Controls.Add(this.offIncr);
            this.groupBox2.Controls.Add(this.OffLbl);
            this.groupBox2.Location = new System.Drawing.Point(405, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 160);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Offset";
            // 
            // offDecr
            // 
            this.offDecr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.offDecr.Location = new System.Drawing.Point(3, 117);
            this.offDecr.Name = "offDecr";
            this.offDecr.Size = new System.Drawing.Size(94, 40);
            this.offDecr.TabIndex = 2;
            this.offDecr.Text = "-";
            this.offDecr.UseVisualStyleBackColor = true;
            this.offDecr.Click += new System.EventHandler(this.offDecr_Click);
            // 
            // offIncr
            // 
            this.offIncr.Dock = System.Windows.Forms.DockStyle.Top;
            this.offIncr.Location = new System.Drawing.Point(3, 22);
            this.offIncr.Name = "offIncr";
            this.offIncr.Size = new System.Drawing.Size(94, 40);
            this.offIncr.TabIndex = 1;
            this.offIncr.Text = "+";
            this.offIncr.UseVisualStyleBackColor = true;
            this.offIncr.Click += new System.EventHandler(this.offIncr_Click);
            // 
            // OffLbl
            // 
            this.OffLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OffLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffLbl.Location = new System.Drawing.Point(3, 22);
            this.OffLbl.Name = "OffLbl";
            this.OffLbl.Size = new System.Drawing.Size(94, 135);
            this.OffLbl.TabIndex = 0;
            this.OffLbl.Text = "0.0";
            this.OffLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(86, 302);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(57, 20);
            this.intervalLabel.TabIndex = 14;
            this.intervalLabel.Text = "200ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Intervallo di acquisizione";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.limitColorBox);
            this.groupBox3.Controls.Add(this.limitBtn);
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
            this.groupBox3.Size = new System.Drawing.Size(200, 208);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colori";
            // 
            // limitColorBox
            // 
            this.limitColorBox.Location = new System.Drawing.Point(152, 165);
            this.limitColorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.limitColorBox.Name = "limitColorBox";
            this.limitColorBox.Size = new System.Drawing.Size(34, 35);
            this.limitColorBox.TabIndex = 11;
            this.limitColorBox.TabStop = false;
            // 
            // limitBtn
            // 
            this.limitBtn.Location = new System.Drawing.Point(8, 165);
            this.limitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.limitBtn.Name = "limitBtn";
            this.limitBtn.Size = new System.Drawing.Size(136, 35);
            this.limitBtn.TabIndex = 10;
            this.limitBtn.Text = "Linee Limite";
            this.limitBtn.UseVisualStyleBackColor = true;
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
            this.inRangeColorBox.Location = new System.Drawing.Point(152, 118);
            this.inRangeColorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inRangeColorBox.Name = "inRangeColorBox";
            this.inRangeColorBox.Size = new System.Drawing.Size(34, 35);
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
            this.button2.Text = "Fuori Raggio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // outRangeColorBox
            // 
            this.outRangeColorBox.Location = new System.Drawing.Point(152, 74);
            this.outRangeColorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outRangeColorBox.Name = "outRangeColorBox";
            this.outRangeColorBox.Size = new System.Drawing.Size(34, 35);
            this.outRangeColorBox.TabIndex = 8;
            this.outRangeColorBox.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 118);
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
            this.chartColorBox.Size = new System.Drawing.Size(34, 35);
            this.chartColorBox.TabIndex = 7;
            this.chartColorBox.TabStop = false;
            // 
            // intervalSel
            // 
            this.intervalSel.LargeChange = 50;
            this.intervalSel.Location = new System.Drawing.Point(9, 252);
            this.intervalSel.Maximum = 1000;
            this.intervalSel.Minimum = 20;
            this.intervalSel.Name = "intervalSel";
            this.intervalSel.Size = new System.Drawing.Size(208, 69);
            this.intervalSel.SmallChange = 5;
            this.intervalSel.TabIndex = 13;
            this.intervalSel.TickFrequency = 100;
            this.intervalSel.Value = 200;
            this.intervalSel.ValueChanged += new System.EventHandler(this.intervalSel_ValueChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(766, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nerd";
            // 
            // Impostazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 531);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Impostazioni";
            this.Text = "Impostazioni";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Impostazioni_FormClosed);
            this.Load += new System.EventHandler(this.Impostazioni_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.limitColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inRangeColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outRangeColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalSel)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox serialCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox baudCombo;
        private System.Windows.Forms.Button okBtn;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar intervalSel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.PictureBox limitColorBox;
        private System.Windows.Forms.Button limitBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.Button minDecr;
        private System.Windows.Forms.Button minIncr;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label secLbl;
        private System.Windows.Forms.Button secDecr;
        private System.Windows.Forms.Button secIncr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox exerciseBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button offDecr;
        private System.Windows.Forms.Button offIncr;
        private System.Windows.Forms.Label OffLbl;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}