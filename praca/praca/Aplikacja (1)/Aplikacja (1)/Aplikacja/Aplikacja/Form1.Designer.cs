namespace Aplikacja
{
    partial class function
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
            this.image1 = new System.Windows.Forms.PictureBox();
            this.open = new System.Windows.Forms.Button();
            this.bar1 = new System.Windows.Forms.HScrollBar();
            this.photos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.image2 = new System.Windows.Forms.PictureBox();
            this.medfilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton3x3 = new System.Windows.Forms.RadioButton();
            this.radioButton5x5 = new System.Windows.Forms.RadioButton();
            this.radioButton7x7 = new System.Windows.Forms.RadioButton();
            this.gaufilter = new System.Windows.Forms.Button();
            this.dft_button = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonDFTA = new System.Windows.Forms.RadioButton();
            this.radioButtonDFTP = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.histogram = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.edgeX_edgeY = new System.Windows.Forms.RadioButton();
            this.edgeY = new System.Windows.Forms.RadioButton();
            this.edgeX = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.bar2_label = new System.Windows.Forms.Label();
            this.bar2 = new System.Windows.Forms.HScrollBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.images3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.images3)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(17, 19);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(215, 213);
            this.image1.TabIndex = 0;
            this.image1.TabStop = false;
            this.image1.Paint += new System.Windows.Forms.PaintEventHandler(this.image1_Paint);
            this.image1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image1_MouseDown);
            this.image1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image1_MouseMove);
            this.image1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.image1_MouseUp);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(17, 239);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(81, 23);
            this.open.TabIndex = 1;
            this.open.Text = "Open Images";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // bar1
            // 
            this.bar1.LargeChange = 1;
            this.bar1.Location = new System.Drawing.Point(11, 311);
            this.bar1.Maximum = 149;
            this.bar1.Minimum = 1;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(200, 28);
            this.bar1.TabIndex = 3;
            this.bar1.Value = 1;
            this.bar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bar1_Scroll);
            // 
            // photos
            // 
            this.photos.AutoSize = true;
            this.photos.Location = new System.Drawing.Point(14, 288);
            this.photos.Name = "photos";
            this.photos.Size = new System.Drawing.Size(40, 13);
            this.photos.TabIndex = 4;
            this.photos.Text = "Photos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Set ROI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reset ROI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(254, 19);
            this.image2.Name = "image2";
            this.image2.Size = new System.Drawing.Size(215, 213);
            this.image2.TabIndex = 8;
            this.image2.TabStop = false;
            // 
            // medfilter
            // 
            this.medfilter.Location = new System.Drawing.Point(10, 25);
            this.medfilter.Name = "medfilter";
            this.medfilter.Size = new System.Drawing.Size(75, 23);
            this.medfilter.TabIndex = 9;
            this.medfilter.Text = "Median Filter";
            this.medfilter.UseVisualStyleBackColor = true;
            this.medfilter.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter Mask:";
            // 
            // radioButton3x3
            // 
            this.radioButton3x3.AutoSize = true;
            this.radioButton3x3.Location = new System.Drawing.Point(169, 20);
            this.radioButton3x3.Name = "radioButton3x3";
            this.radioButton3x3.Size = new System.Drawing.Size(42, 17);
            this.radioButton3x3.TabIndex = 12;
            this.radioButton3x3.TabStop = true;
            this.radioButton3x3.Text = "3x3";
            this.radioButton3x3.UseVisualStyleBackColor = true;
            this.radioButton3x3.Click += new System.EventHandler(this.radioButton3x3_Click);
            // 
            // radioButton5x5
            // 
            this.radioButton5x5.AutoSize = true;
            this.radioButton5x5.Location = new System.Drawing.Point(169, 44);
            this.radioButton5x5.Name = "radioButton5x5";
            this.radioButton5x5.Size = new System.Drawing.Size(42, 17);
            this.radioButton5x5.TabIndex = 13;
            this.radioButton5x5.TabStop = true;
            this.radioButton5x5.Text = "5x5";
            this.radioButton5x5.UseVisualStyleBackColor = true;
            this.radioButton5x5.Click += new System.EventHandler(this.radioButton5x5_Click);
            // 
            // radioButton7x7
            // 
            this.radioButton7x7.AutoSize = true;
            this.radioButton7x7.Location = new System.Drawing.Point(169, 68);
            this.radioButton7x7.Name = "radioButton7x7";
            this.radioButton7x7.Size = new System.Drawing.Size(42, 17);
            this.radioButton7x7.TabIndex = 14;
            this.radioButton7x7.TabStop = true;
            this.radioButton7x7.Text = "7x7";
            this.radioButton7x7.UseVisualStyleBackColor = true;
            this.radioButton7x7.Click += new System.EventHandler(this.radioButton7x7_Click);
            // 
            // gaufilter
            // 
            this.gaufilter.Location = new System.Drawing.Point(10, 67);
            this.gaufilter.Name = "gaufilter";
            this.gaufilter.Size = new System.Drawing.Size(75, 23);
            this.gaufilter.TabIndex = 15;
            this.gaufilter.Text = "Gauss Filter";
            this.gaufilter.UseVisualStyleBackColor = true;
            this.gaufilter.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dft_button
            // 
            this.dft_button.Location = new System.Drawing.Point(9, 31);
            this.dft_button.Name = "dft_button";
            this.dft_button.Size = new System.Drawing.Size(75, 23);
            this.dft_button.TabIndex = 16;
            this.dft_button.Text = "DFT";
            this.dft_button.UseVisualStyleBackColor = true;
            this.dft_button.Click += new System.EventHandler(this.dft_button_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 2;
            this.trackBar2.Location = new System.Drawing.Point(111, 164);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(156, 45);
            this.trackBar2.TabIndex = 17;
            this.trackBar2.Value = 127;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 18;
            // 
            // radioButtonDFTA
            // 
            this.radioButtonDFTA.AutoSize = true;
            this.radioButtonDFTA.Location = new System.Drawing.Point(107, 24);
            this.radioButtonDFTA.Name = "radioButtonDFTA";
            this.radioButtonDFTA.Size = new System.Drawing.Size(95, 17);
            this.radioButtonDFTA.TabIndex = 20;
            this.radioButtonDFTA.TabStop = true;
            this.radioButtonDFTA.Text = "DFT Amplitude";
            this.radioButtonDFTA.UseVisualStyleBackColor = true;
            this.radioButtonDFTA.Click += new System.EventHandler(this.dfta_click);
            // 
            // radioButtonDFTP
            // 
            this.radioButtonDFTP.AutoSize = true;
            this.radioButtonDFTP.Location = new System.Drawing.Point(107, 47);
            this.radioButtonDFTP.Name = "radioButtonDFTP";
            this.radioButtonDFTP.Size = new System.Drawing.Size(79, 17);
            this.radioButtonDFTP.TabIndex = 21;
            this.radioButtonDFTP.TabStop = true;
            this.radioButtonDFTP.Text = "DFT Phase";
            this.radioButtonDFTP.UseVisualStyleBackColor = true;
            this.radioButtonDFTP.Click += new System.EventHandler(this.dftp_click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Set Image Contrast:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Image Contrast";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // histogram
            // 
            this.histogram.Location = new System.Drawing.Point(145, 135);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(100, 23);
            this.histogram.TabIndex = 24;
            this.histogram.Text = "Stretch histogram";
            this.histogram.UseVisualStyleBackColor = true;
            this.histogram.Click += new System.EventHandler(this.histogram_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Autumn:  red orange yellow",
            "Bone: gray scale with blue",
            "Infrared: purple orange yellow blue",
            "Summer: green yellow shades",
            "Winter: blue green shades"});
            this.comboBox1.Location = new System.Drawing.Point(17, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Edge Detection";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // edgeX_edgeY
            // 
            this.edgeX_edgeY.AutoSize = true;
            this.edgeX_edgeY.Location = new System.Drawing.Point(118, 394);
            this.edgeX_edgeY.Name = "edgeX_edgeY";
            this.edgeX_edgeY.Size = new System.Drawing.Size(110, 17);
            this.edgeX_edgeY.TabIndex = 29;
            this.edgeX_edgeY.TabStop = true;
            this.edgeX_edgeY.Text = "EdgeDetectionXY";
            this.edgeX_edgeY.UseVisualStyleBackColor = true;
            // 
            // edgeY
            // 
            this.edgeY.AutoSize = true;
            this.edgeY.Location = new System.Drawing.Point(118, 349);
            this.edgeY.Name = "edgeY";
            this.edgeY.Size = new System.Drawing.Size(103, 17);
            this.edgeY.TabIndex = 28;
            this.edgeY.TabStop = true;
            this.edgeY.Text = "EdgeDetectionY";
            this.edgeY.UseVisualStyleBackColor = true;
            // 
            // edgeX
            // 
            this.edgeX.AutoSize = true;
            this.edgeX.Location = new System.Drawing.Point(118, 371);
            this.edgeX.Name = "edgeX";
            this.edgeX.Size = new System.Drawing.Size(103, 17);
            this.edgeX.TabIndex = 30;
            this.edgeX.TabStop = true;
            this.edgeX.Text = "EdgeDetectionX";
            this.edgeX.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 82);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "Derivatives";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(108, 77);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 17);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "First Derivative";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(108, 102);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Second Derivative";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Set the color palette:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.bar2_label);
            this.groupBox3.Controls.Add(this.bar2);
            this.groupBox3.Controls.Add(this.image1);
            this.groupBox3.Controls.Add(this.image2);
            this.groupBox3.Controls.Add(this.open);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.bar1);
            this.groupBox3.Controls.Add(this.photos);
            this.groupBox3.Location = new System.Drawing.Point(9, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 433);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Work panel";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(405, 287);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(77, 17);
            this.checkBox5.TabIndex = 42;
            this.checkBox5.Text = "One image";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(405, 266);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(75, 17);
            this.checkBox4.TabIndex = 41;
            this.checkBox4.Text = "Sequence";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(124, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(405, 238);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 23);
            this.button7.TabIndex = 39;
            this.button7.Text = "Save Photos";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // bar2_label
            // 
            this.bar2_label.AutoSize = true;
            this.bar2_label.Location = new System.Drawing.Point(243, 290);
            this.bar2_label.Name = "bar2_label";
            this.bar2_label.Size = new System.Drawing.Size(93, 13);
            this.bar2_label.TabIndex = 28;
            this.bar2_label.Text = "Processed images";
            // 
            // bar2
            // 
            this.bar2.LargeChange = 1;
            this.bar2.Location = new System.Drawing.Point(246, 310);
            this.bar2.Maximum = 149;
            this.bar2.Minimum = 1;
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(218, 28);
            this.bar2.TabIndex = 3;
            this.bar2.Value = 1;
            this.bar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bar2_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.edgeX);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.edgeX_edgeY);
            this.groupBox2.Controls.Add(this.histogram);
            this.groupBox2.Controls.Add(this.edgeY);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.trackBar2);
            this.groupBox2.Location = new System.Drawing.Point(502, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 420);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image processing";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.medfilter);
            this.groupBox1.Controls.Add(this.gaufilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton3x3);
            this.groupBox1.Controls.Add(this.radioButton5x5);
            this.groupBox1.Controls.Add(this.radioButton7x7);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 110);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image filtering";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dft_button);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.radioButtonDFTA);
            this.groupBox4.Controls.Add(this.radioButtonDFTP);
            this.groupBox4.Location = new System.Drawing.Point(10, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 140);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sequence processing";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(216, 364);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 23);
            this.button8.TabIndex = 41;
            this.button8.Text = "Draw histogram";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // images3
            // 
            this.images3.Location = new System.Drawing.Point(35, 61);
            this.images3.Name = "images3";
            this.images3.Size = new System.Drawing.Size(236, 239);
            this.images3.TabIndex = 42;
            this.images3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "150";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "200";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "255";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "50";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "100";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "150";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "200";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 55;
            this.label16.Text = "255";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(290, 309);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 56;
            this.label17.Text = "Pxl";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 57;
            this.label18.Text = "Value";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.images3);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(797, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 413);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Draw Histogram";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 368);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(202, 17);
            this.checkBox3.TabIndex = 60;
            this.checkBox3.Text = "Count histogram for actual image ROI";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 391);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(208, 17);
            this.checkBox2.TabIndex = 59;
            this.checkBox2.Text = "Stretch histogram for actual image ROI";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 344);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Set line values";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 457);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Name = "function";
            this.Text = "Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.images3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.HScrollBar bar1;
        private System.Windows.Forms.Label photos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.PictureBox image2;
        private System.Windows.Forms.Button medfilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3x3;
        private System.Windows.Forms.RadioButton radioButton5x5;
        private System.Windows.Forms.RadioButton radioButton7x7;
        private System.Windows.Forms.Button gaufilter;
        private System.Windows.Forms.Button dft_button;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonDFTA;
        private System.Windows.Forms.RadioButton radioButtonDFTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button histogram;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton edgeX_edgeY;
        private System.Windows.Forms.RadioButton edgeY;
        private System.Windows.Forms.RadioButton edgeX;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label bar2_label;
        private System.Windows.Forms.HScrollBar bar2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox images3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

