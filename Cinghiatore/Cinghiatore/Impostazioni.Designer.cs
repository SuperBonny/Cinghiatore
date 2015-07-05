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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.offSecDecr = new System.Windows.Forms.Button();
            this.offSecIncr = new System.Windows.Forms.Button();
            this.offSecLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.offDecr = new System.Windows.Forms.Button();
            this.offIncr = new System.Windows.Forms.Button();
            this.OffLbl = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.serialCombo.Location = new System.Drawing.Point(5, 31);
            this.serialCombo.Name = "serialCombo";
            this.serialCombo.Size = new System.Drawing.Size(95, 21);
            this.serialCombo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.baudCombo);
            this.groupBox1.Controls.Add(this.serialCombo);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seriale";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Cinghiatore.Properties.Resources.Refresh_icon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(104, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(19, 18);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
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
            this.baudCombo.Location = new System.Drawing.Point(5, 69);
            this.baudCombo.Name = "baudCombo";
            this.baudCombo.Size = new System.Drawing.Size(95, 21);
            this.baudCombo.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(459, 0);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(55, 23);
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
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 346);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.exerciseBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(508, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Esercizi";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.offSecDecr);
            this.groupBox6.Controls.Add(this.offSecIncr);
            this.groupBox6.Controls.Add(this.offSecLbl);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(361, 17);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(67, 104);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Secondi";
            // 
            // offSecDecr
            // 
            this.offSecDecr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.offSecDecr.Location = new System.Drawing.Point(2, 76);
            this.offSecDecr.Margin = new System.Windows.Forms.Padding(2);
            this.offSecDecr.Name = "offSecDecr";
            this.offSecDecr.Size = new System.Drawing.Size(63, 26);
            this.offSecDecr.TabIndex = 2;
            this.offSecDecr.Text = "-";
            this.offSecDecr.UseVisualStyleBackColor = true;
            this.offSecDecr.Click += new System.EventHandler(this.offSecDecr_Click);
            // 
            // offSecIncr
            // 
            this.offSecIncr.Dock = System.Windows.Forms.DockStyle.Top;
            this.offSecIncr.Location = new System.Drawing.Point(2, 15);
            this.offSecIncr.Margin = new System.Windows.Forms.Padding(2);
            this.offSecIncr.Name = "offSecIncr";
            this.offSecIncr.Size = new System.Drawing.Size(63, 26);
            this.offSecIncr.TabIndex = 1;
            this.offSecIncr.Text = "+";
            this.offSecIncr.UseVisualStyleBackColor = true;
            this.offSecIncr.Click += new System.EventHandler(this.offSecIncr_Click);
            // 
            // offSecLbl
            // 
            this.offSecLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offSecLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offSecLbl.Location = new System.Drawing.Point(2, 15);
            this.offSecLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.offSecLbl.Name = "offSecLbl";
            this.offSecLbl.Size = new System.Drawing.Size(63, 87);
            this.offSecLbl.TabIndex = 0;
            this.offSecLbl.Text = "0";
            this.offSecLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.offDecr);
            this.groupBox2.Controls.Add(this.offIncr);
            this.groupBox2.Controls.Add(this.OffLbl);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(275, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(67, 104);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Offset";
            // 
            // offDecr
            // 
            this.offDecr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.offDecr.Location = new System.Drawing.Point(2, 76);
            this.offDecr.Margin = new System.Windows.Forms.Padding(2);
            this.offDecr.Name = "offDecr";
            this.offDecr.Size = new System.Drawing.Size(63, 26);
            this.offDecr.TabIndex = 2;
            this.offDecr.Text = "-";
            this.offDecr.UseVisualStyleBackColor = true;
            this.offDecr.Click += new System.EventHandler(this.offDecr_Click_1);
            // 
            // offIncr
            // 
            this.offIncr.Dock = System.Windows.Forms.DockStyle.Top;
            this.offIncr.Location = new System.Drawing.Point(2, 15);
            this.offIncr.Margin = new System.Windows.Forms.Padding(2);
            this.offIncr.Name = "offIncr";
            this.offIncr.Size = new System.Drawing.Size(63, 26);
            this.offIncr.TabIndex = 1;
            this.offIncr.Text = "+";
            this.offIncr.UseVisualStyleBackColor = true;
            this.offIncr.Click += new System.EventHandler(this.offIncr_Click_1);
            // 
            // OffLbl
            // 
            this.OffLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OffLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffLbl.Location = new System.Drawing.Point(2, 15);
            this.OffLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OffLbl.Name = "OffLbl";
            this.OffLbl.Size = new System.Drawing.Size(63, 87);
            this.OffLbl.TabIndex = 0;
            this.OffLbl.Text = "0.0";
            this.OffLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.minDecr);
            this.groupBox4.Controls.Add(this.minIncr);
            this.groupBox4.Controls.Add(this.minLbl);
            this.groupBox4.Location = new System.Drawing.Point(277, 160);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(67, 104);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minuti";
            // 
            // minDecr
            // 
            this.minDecr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.minDecr.Location = new System.Drawing.Point(2, 76);
            this.minDecr.Margin = new System.Windows.Forms.Padding(2);
            this.minDecr.Name = "minDecr";
            this.minDecr.Size = new System.Drawing.Size(63, 26);
            this.minDecr.TabIndex = 2;
            this.minDecr.Text = "-";
            this.minDecr.UseVisualStyleBackColor = true;
            this.minDecr.Click += new System.EventHandler(this.minDecr_Click);
            // 
            // minIncr
            // 
            this.minIncr.Dock = System.Windows.Forms.DockStyle.Top;
            this.minIncr.Location = new System.Drawing.Point(2, 15);
            this.minIncr.Margin = new System.Windows.Forms.Padding(2);
            this.minIncr.Name = "minIncr";
            this.minIncr.Size = new System.Drawing.Size(63, 26);
            this.minIncr.TabIndex = 1;
            this.minIncr.Text = "+";
            this.minIncr.UseVisualStyleBackColor = true;
            this.minIncr.Click += new System.EventHandler(this.minIncr_Click);
            // 
            // minLbl
            // 
            this.minLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLbl.Location = new System.Drawing.Point(2, 15);
            this.minLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(63, 87);
            this.minLbl.TabIndex = 0;
            this.minLbl.Text = "0";
            this.minLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.secDecr);
            this.groupBox5.Controls.Add(this.secIncr);
            this.groupBox5.Controls.Add(this.secLbl);
            this.groupBox5.Location = new System.Drawing.Point(362, 160);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(67, 104);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Secondi";
            // 
            // secDecr
            // 
            this.secDecr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.secDecr.Location = new System.Drawing.Point(2, 76);
            this.secDecr.Margin = new System.Windows.Forms.Padding(2);
            this.secDecr.Name = "secDecr";
            this.secDecr.Size = new System.Drawing.Size(63, 26);
            this.secDecr.TabIndex = 2;
            this.secDecr.Text = "-";
            this.secDecr.UseVisualStyleBackColor = true;
            this.secDecr.Click += new System.EventHandler(this.secDecr_Click);
            // 
            // secIncr
            // 
            this.secIncr.Dock = System.Windows.Forms.DockStyle.Top;
            this.secIncr.Location = new System.Drawing.Point(2, 15);
            this.secIncr.Margin = new System.Windows.Forms.Padding(2);
            this.secIncr.Name = "secIncr";
            this.secIncr.Size = new System.Drawing.Size(63, 26);
            this.secIncr.TabIndex = 1;
            this.secIncr.Text = "+";
            this.secIncr.UseVisualStyleBackColor = true;
            this.secIncr.Click += new System.EventHandler(this.secIncr_Click);
            // 
            // secLbl
            // 
            this.secLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLbl.Location = new System.Drawing.Point(2, 15);
            this.secLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secLbl.Name = "secLbl";
            this.secLbl.Size = new System.Drawing.Size(63, 87);
            this.secLbl.TabIndex = 0;
            this.secLbl.Text = "0";
            this.secLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 39);
            this.label6.TabIndex = 8;
            this.label6.Text = ":";
            // 
            // exerciseBox
            // 
            this.exerciseBox.FormattingEnabled = true;
            this.exerciseBox.Items.AddRange(new object[] {
            "Libero",
            "Massimale",
            "Resistenza"});
            this.exerciseBox.Location = new System.Drawing.Point(166, 17);
            this.exerciseBox.Margin = new System.Windows.Forms.Padding(2);
            this.exerciseBox.Name = "exerciseBox";
            this.exerciseBox.Size = new System.Drawing.Size(81, 82);
            this.exerciseBox.TabIndex = 5;
            this.exerciseBox.SelectedIndexChanged += new System.EventHandler(this.exerciseBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo di Esercizio";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage3.Controls.Add(this.intervalLabel);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.intervalSel);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(508, 308);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generali";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(57, 196);
            this.intervalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(38, 13);
            this.intervalLabel.TabIndex = 14;
            this.intervalLabel.Text = "200ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
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
            this.groupBox3.Location = new System.Drawing.Point(6, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 135);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colori";
            // 
            // limitColorBox
            // 
            this.limitColorBox.Location = new System.Drawing.Point(101, 107);
            this.limitColorBox.Name = "limitColorBox";
            this.limitColorBox.Size = new System.Drawing.Size(23, 23);
            this.limitColorBox.TabIndex = 11;
            this.limitColorBox.TabStop = false;
            // 
            // limitBtn
            // 
            this.limitBtn.Location = new System.Drawing.Point(5, 107);
            this.limitBtn.Name = "limitBtn";
            this.limitBtn.Size = new System.Drawing.Size(91, 23);
            this.limitBtn.TabIndex = 10;
            this.limitBtn.Text = "Linee Limite";
            this.limitBtn.UseVisualStyleBackColor = true;
            this.limitBtn.Click += new System.EventHandler(this.limitBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Grafico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inRangeColorBox
            // 
            this.inRangeColorBox.Location = new System.Drawing.Point(101, 77);
            this.inRangeColorBox.Name = "inRangeColorBox";
            this.inRangeColorBox.Size = new System.Drawing.Size(23, 23);
            this.inRangeColorBox.TabIndex = 9;
            this.inRangeColorBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Fuori Raggio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // outRangeColorBox
            // 
            this.outRangeColorBox.Location = new System.Drawing.Point(101, 48);
            this.outRangeColorBox.Name = "outRangeColorBox";
            this.outRangeColorBox.Size = new System.Drawing.Size(23, 23);
            this.outRangeColorBox.TabIndex = 8;
            this.outRangeColorBox.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "inRange";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chartColorBox
            // 
            this.chartColorBox.BackColor = System.Drawing.Color.Transparent;
            this.chartColorBox.Location = new System.Drawing.Point(101, 19);
            this.chartColorBox.Name = "chartColorBox";
            this.chartColorBox.Size = new System.Drawing.Size(23, 23);
            this.chartColorBox.TabIndex = 7;
            this.chartColorBox.TabStop = false;
            // 
            // intervalSel
            // 
            this.intervalSel.LargeChange = 50;
            this.intervalSel.Location = new System.Drawing.Point(6, 164);
            this.intervalSel.Margin = new System.Windows.Forms.Padding(2);
            this.intervalSel.Maximum = 1000;
            this.intervalSel.Minimum = 20;
            this.intervalSel.Name = "intervalSel";
            this.intervalSel.Size = new System.Drawing.Size(139, 45);
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
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(508, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nerd";
            // 
            // Impostazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 345);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button offSecDecr;
        private System.Windows.Forms.Button offSecIncr;
        private System.Windows.Forms.Label offSecLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button offDecr;
        private System.Windows.Forms.Button offIncr;
        private System.Windows.Forms.Label OffLbl;
    }
}