namespace GameboyCameraClient
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_gain_value = new System.Windows.Forms.Label();
            this.label_gain = new System.Windows.Forms.Label();
            this.trackBar_gain = new System.Windows.Forms.TrackBar();
            this.label_c0_value = new System.Windows.Forms.Label();
            this.label_c1_value = new System.Windows.Forms.Label();
            this.label_c1 = new System.Windows.Forms.Label();
            this.trackBar_c0 = new System.Windows.Forms.TrackBar();
            this.label_c0 = new System.Windows.Forms.Label();
            this.trackBar_c1 = new System.Windows.Forms.TrackBar();
            this.label_calibration_value = new System.Windows.Forms.Label();
            this.label_calibration = new System.Windows.Forms.Label();
            this.comboBox_calibration = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox_comport = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_vhmode_value = new System.Windows.Forms.Label();
            this.label_edge_value = new System.Windows.Forms.Label();
            this.trackBar_edge = new System.Windows.Forms.TrackBar();
            this.label_edge = new System.Windows.Forms.Label();
            this.label_vhmode = new System.Windows.Forms.Label();
            this.comboBox_vhmode = new System.Windows.Forms.ComboBox();
            this.checkBox_n = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_x = new System.Windows.Forms.CheckBox();
            this.checkBox_m = new System.Windows.Forms.CheckBox();
            this.checkBox_p = new System.Windows.Forms.CheckBox();
            this.checkBox_inverted = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_vref_value = new System.Windows.Forms.Label();
            this.trackBar_vref = new System.Windows.Forms.TrackBar();
            this.label_vref = new System.Windows.Forms.Label();
            this.label_offset_value = new System.Windows.Forms.Label();
            this.trackBar_offset = new System.Windows.Forms.TrackBar();
            this.label_offset = new System.Windows.Forms.Label();
            this.comboBox_edge_enhancement_mode = new System.Windows.Forms.ComboBox();
            this.label_edge_enhancement_mode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_c0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_c1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_edge)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_vref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_offset)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(900, 255);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(90, 21);
            this.bt_start.TabIndex = 1;
            this.bt_start.Text = "Take Picture";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_gain_value);
            this.groupBox1.Controls.Add(this.label_gain);
            this.groupBox1.Controls.Add(this.trackBar_gain);
            this.groupBox1.Controls.Add(this.label_c0_value);
            this.groupBox1.Controls.Add(this.label_c1_value);
            this.groupBox1.Controls.Add(this.label_c1);
            this.groupBox1.Controls.Add(this.trackBar_c0);
            this.groupBox1.Controls.Add(this.label_c0);
            this.groupBox1.Controls.Add(this.trackBar_c1);
            this.groupBox1.Location = new System.Drawing.Point(299, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Light";
            // 
            // label_gain_value
            // 
            this.label_gain_value.AutoSize = true;
            this.label_gain_value.Location = new System.Drawing.Point(43, 115);
            this.label_gain_value.Name = "label_gain_value";
            this.label_gain_value.Size = new System.Drawing.Size(12, 13);
            this.label_gain_value.TabIndex = 8;
            this.label_gain_value.Text = "x";
            // 
            // label_gain
            // 
            this.label_gain.AutoSize = true;
            this.label_gain.Location = new System.Drawing.Point(14, 115);
            this.label_gain.Name = "label_gain";
            this.label_gain.Size = new System.Drawing.Size(32, 13);
            this.label_gain.TabIndex = 7;
            this.label_gain.Text = "Gain:";
            // 
            // trackBar_gain
            // 
            this.trackBar_gain.LargeChange = 1;
            this.trackBar_gain.Location = new System.Drawing.Point(17, 131);
            this.trackBar_gain.Maximum = 31;
            this.trackBar_gain.Name = "trackBar_gain";
            this.trackBar_gain.Size = new System.Drawing.Size(231, 45);
            this.trackBar_gain.TabIndex = 6;
            this.trackBar_gain.Scroll += new System.EventHandler(this.trackBar_gain_Scroll);
            // 
            // label_c0_value
            // 
            this.label_c0_value.AutoSize = true;
            this.label_c0_value.Location = new System.Drawing.Point(43, 64);
            this.label_c0_value.Name = "label_c0_value";
            this.label_c0_value.Size = new System.Drawing.Size(12, 13);
            this.label_c0_value.TabIndex = 5;
            this.label_c0_value.Text = "x";
            // 
            // label_c1_value
            // 
            this.label_c1_value.AutoSize = true;
            this.label_c1_value.Location = new System.Drawing.Point(43, 16);
            this.label_c1_value.Name = "label_c1_value";
            this.label_c1_value.Size = new System.Drawing.Size(12, 13);
            this.label_c1_value.TabIndex = 4;
            this.label_c1_value.Text = "x";
            // 
            // label_c1
            // 
            this.label_c1.AutoSize = true;
            this.label_c1.Location = new System.Drawing.Point(14, 16);
            this.label_c1.Name = "label_c1";
            this.label_c1.Size = new System.Drawing.Size(23, 13);
            this.label_c1.TabIndex = 3;
            this.label_c1.Text = "C1:";
            // 
            // trackBar_c0
            // 
            this.trackBar_c0.LargeChange = 1;
            this.trackBar_c0.Location = new System.Drawing.Point(17, 80);
            this.trackBar_c0.Maximum = 255;
            this.trackBar_c0.Name = "trackBar_c0";
            this.trackBar_c0.Size = new System.Drawing.Size(231, 45);
            this.trackBar_c0.TabIndex = 2;
            this.trackBar_c0.Scroll += new System.EventHandler(this.trackBar_c0_Scroll);
            // 
            // label_c0
            // 
            this.label_c0.AutoSize = true;
            this.label_c0.Location = new System.Drawing.Point(14, 64);
            this.label_c0.Name = "label_c0";
            this.label_c0.Size = new System.Drawing.Size(26, 13);
            this.label_c0.TabIndex = 1;
            this.label_c0.Text = "C0: ";
            // 
            // trackBar_c1
            // 
            this.trackBar_c1.LargeChange = 1;
            this.trackBar_c1.Location = new System.Drawing.Point(17, 32);
            this.trackBar_c1.Maximum = 255;
            this.trackBar_c1.Name = "trackBar_c1";
            this.trackBar_c1.Size = new System.Drawing.Size(231, 45);
            this.trackBar_c1.TabIndex = 0;
            this.trackBar_c1.Scroll += new System.EventHandler(this.trackBar_c1_Scroll);
            // 
            // label_calibration_value
            // 
            this.label_calibration_value.AutoSize = true;
            this.label_calibration_value.Location = new System.Drawing.Point(89, 171);
            this.label_calibration_value.Name = "label_calibration_value";
            this.label_calibration_value.Size = new System.Drawing.Size(12, 13);
            this.label_calibration_value.TabIndex = 12;
            this.label_calibration_value.Text = "x";
            // 
            // label_calibration
            // 
            this.label_calibration.AutoSize = true;
            this.label_calibration.Location = new System.Drawing.Point(5, 171);
            this.label_calibration.Name = "label_calibration";
            this.label_calibration.Size = new System.Drawing.Size(78, 13);
            this.label_calibration.TabIndex = 11;
            this.label_calibration.Text = "Calibration (Z): ";
            // 
            // comboBox_calibration
            // 
            this.comboBox_calibration.FormattingEnabled = true;
            this.comboBox_calibration.Location = new System.Drawing.Point(17, 187);
            this.comboBox_calibration.Name = "comboBox_calibration";
            this.comboBox_calibration.Size = new System.Drawing.Size(160, 21);
            this.comboBox_calibration.TabIndex = 10;
            this.comboBox_calibration.SelectedIndexChanged += new System.EventHandler(this.comboBox_calibration_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 295);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1049, 320);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox_comport
            // 
            this.comboBox_comport.FormattingEnabled = true;
            this.comboBox_comport.Location = new System.Drawing.Point(6, 19);
            this.comboBox_comport.Name = "comboBox_comport";
            this.comboBox_comport.Size = new System.Drawing.Size(121, 21);
            this.comboBox_comport.TabIndex = 4;
            this.comboBox_comport.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_baud);
            this.groupBox2.Controls.Add(this.comboBox_comport);
            this.groupBox2.Location = new System.Drawing.Point(414, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 82);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial";
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Location = new System.Drawing.Point(6, 47);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(121, 21);
            this.comboBox_baud.TabIndex = 5;
            this.comboBox_baud.SelectedIndexChanged += new System.EventHandler(this.comboBox_baud_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_edge_enhancement_mode);
            this.groupBox3.Controls.Add(this.comboBox_edge_enhancement_mode);
            this.groupBox3.Controls.Add(this.label_vhmode_value);
            this.groupBox3.Controls.Add(this.label_edge_value);
            this.groupBox3.Controls.Add(this.trackBar_edge);
            this.groupBox3.Controls.Add(this.label_edge);
            this.groupBox3.Controls.Add(this.label_vhmode);
            this.groupBox3.Controls.Add(this.comboBox_vhmode);
            this.groupBox3.Controls.Add(this.checkBox_n);
            this.groupBox3.Location = new System.Drawing.Point(811, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 222);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edge extraction";
            // 
            // label_vhmode_value
            // 
            this.label_vhmode_value.AutoSize = true;
            this.label_vhmode_value.Location = new System.Drawing.Point(67, 63);
            this.label_vhmode_value.Name = "label_vhmode_value";
            this.label_vhmode_value.Size = new System.Drawing.Size(12, 13);
            this.label_vhmode_value.TabIndex = 19;
            this.label_vhmode_value.Text = "x";
            // 
            // label_edge_value
            // 
            this.label_edge_value.AutoSize = true;
            this.label_edge_value.Location = new System.Drawing.Point(138, 112);
            this.label_edge_value.Name = "label_edge_value";
            this.label_edge_value.Size = new System.Drawing.Size(12, 13);
            this.label_edge_value.TabIndex = 18;
            this.label_edge_value.Text = "x";
            // 
            // trackBar_edge
            // 
            this.trackBar_edge.LargeChange = 1;
            this.trackBar_edge.Location = new System.Drawing.Point(9, 131);
            this.trackBar_edge.Maximum = 7;
            this.trackBar_edge.Name = "trackBar_edge";
            this.trackBar_edge.Size = new System.Drawing.Size(185, 45);
            this.trackBar_edge.TabIndex = 9;
            this.trackBar_edge.Scroll += new System.EventHandler(this.trackBar_edge_Scroll);
            // 
            // label_edge
            // 
            this.label_edge.AutoSize = true;
            this.label_edge.Location = new System.Drawing.Point(6, 112);
            this.label_edge.Name = "label_edge";
            this.label_edge.Size = new System.Drawing.Size(139, 13);
            this.label_edge.TabIndex = 8;
            this.label_edge.Text = "E: Edge enhancement ratio:";
            // 
            // label_vhmode
            // 
            this.label_vhmode.AutoSize = true;
            this.label_vhmode.Location = new System.Drawing.Point(6, 63);
            this.label_vhmode.Name = "label_vhmode";
            this.label_vhmode.Size = new System.Drawing.Size(55, 13);
            this.label_vhmode.TabIndex = 7;
            this.label_vhmode.Text = "VH-Mode:";
            // 
            // comboBox_vhmode
            // 
            this.comboBox_vhmode.FormattingEnabled = true;
            this.comboBox_vhmode.Location = new System.Drawing.Point(9, 79);
            this.comboBox_vhmode.Name = "comboBox_vhmode";
            this.comboBox_vhmode.Size = new System.Drawing.Size(160, 21);
            this.comboBox_vhmode.TabIndex = 6;
            this.comboBox_vhmode.SelectedIndexChanged += new System.EventHandler(this.comboBox_vhmode_SelectedIndexChanged);
            // 
            // checkBox_n
            // 
            this.checkBox_n.AutoSize = true;
            this.checkBox_n.Location = new System.Drawing.Point(9, 32);
            this.checkBox_n.Name = "checkBox_n";
            this.checkBox_n.Size = new System.Drawing.Size(161, 17);
            this.checkBox_n.TabIndex = 0;
            this.checkBox_n.Text = "N: Set edge extraction mode";
            this.checkBox_n.UseVisualStyleBackColor = true;
            this.checkBox_n.CheckedChanged += new System.EventHandler(this.checkBox_n_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_x);
            this.groupBox4.Controls.Add(this.checkBox_m);
            this.groupBox4.Controls.Add(this.checkBox_p);
            this.groupBox4.Location = new System.Drawing.Point(299, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(107, 82);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "1-D filtering kernel";
            // 
            // checkBox_x
            // 
            this.checkBox_x.AutoSize = true;
            this.checkBox_x.Checked = true;
            this.checkBox_x.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_x.Location = new System.Drawing.Point(11, 51);
            this.checkBox_x.Name = "checkBox_x";
            this.checkBox_x.Size = new System.Drawing.Size(33, 17);
            this.checkBox_x.TabIndex = 12;
            this.checkBox_x.Text = "X";
            this.checkBox_x.UseVisualStyleBackColor = true;
            this.checkBox_x.CheckedChanged += new System.EventHandler(this.checkBox_x_CheckedChanged);
            // 
            // checkBox_m
            // 
            this.checkBox_m.AutoSize = true;
            this.checkBox_m.Location = new System.Drawing.Point(57, 28);
            this.checkBox_m.Name = "checkBox_m";
            this.checkBox_m.Size = new System.Drawing.Size(35, 17);
            this.checkBox_m.TabIndex = 11;
            this.checkBox_m.Text = "M";
            this.checkBox_m.UseVisualStyleBackColor = true;
            this.checkBox_m.CheckedChanged += new System.EventHandler(this.checkBox_m_CheckedChanged);
            // 
            // checkBox_p
            // 
            this.checkBox_p.AutoSize = true;
            this.checkBox_p.Checked = true;
            this.checkBox_p.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_p.Location = new System.Drawing.Point(11, 28);
            this.checkBox_p.Name = "checkBox_p";
            this.checkBox_p.Size = new System.Drawing.Size(33, 17);
            this.checkBox_p.TabIndex = 10;
            this.checkBox_p.Text = "P";
            this.checkBox_p.UseVisualStyleBackColor = true;
            this.checkBox_p.CheckedChanged += new System.EventHandler(this.checkBox_p_CheckedChanged);
            // 
            // checkBox_inverted
            // 
            this.checkBox_inverted.AutoSize = true;
            this.checkBox_inverted.Location = new System.Drawing.Point(9, 135);
            this.checkBox_inverted.Name = "checkBox_inverted";
            this.checkBox_inverted.Size = new System.Drawing.Size(74, 17);
            this.checkBox_inverted.TabIndex = 13;
            this.checkBox_inverted.Text = "I: Inverted";
            this.checkBox_inverted.UseVisualStyleBackColor = true;
            this.checkBox_inverted.CheckedChanged += new System.EventHandler(this.checkBox_inverted_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label_calibration_value);
            this.groupBox5.Controls.Add(this.checkBox_inverted);
            this.groupBox5.Controls.Add(this.label_calibration);
            this.groupBox5.Controls.Add(this.label_vref_value);
            this.groupBox5.Controls.Add(this.comboBox_calibration);
            this.groupBox5.Controls.Add(this.trackBar_vref);
            this.groupBox5.Controls.Add(this.label_vref);
            this.groupBox5.Controls.Add(this.label_offset_value);
            this.groupBox5.Controls.Add(this.trackBar_offset);
            this.groupBox5.Controls.Add(this.label_offset);
            this.groupBox5.Location = new System.Drawing.Point(555, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 277);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Image settings";
            // 
            // label_vref_value
            // 
            this.label_vref_value.AutoSize = true;
            this.label_vref_value.Location = new System.Drawing.Point(50, 72);
            this.label_vref_value.Name = "label_vref_value";
            this.label_vref_value.Size = new System.Drawing.Size(12, 13);
            this.label_vref_value.TabIndex = 17;
            this.label_vref_value.Text = "x";
            // 
            // trackBar_vref
            // 
            this.trackBar_vref.LargeChange = 1;
            this.trackBar_vref.Location = new System.Drawing.Point(6, 88);
            this.trackBar_vref.Maximum = 7;
            this.trackBar_vref.Name = "trackBar_vref";
            this.trackBar_vref.Size = new System.Drawing.Size(238, 45);
            this.trackBar_vref.TabIndex = 15;
            this.trackBar_vref.Scroll += new System.EventHandler(this.trackBar_vref_Scroll);
            // 
            // label_vref
            // 
            this.label_vref.AutoSize = true;
            this.label_vref.Location = new System.Drawing.Point(6, 72);
            this.label_vref.Name = "label_vref";
            this.label_vref.Size = new System.Drawing.Size(29, 13);
            this.label_vref.TabIndex = 16;
            this.label_vref.Text = "Vref:";
            // 
            // label_offset_value
            // 
            this.label_offset_value.AutoSize = true;
            this.label_offset_value.Location = new System.Drawing.Point(50, 21);
            this.label_offset_value.Name = "label_offset_value";
            this.label_offset_value.Size = new System.Drawing.Size(12, 13);
            this.label_offset_value.TabIndex = 14;
            this.label_offset_value.Text = "x";
            // 
            // trackBar_offset
            // 
            this.trackBar_offset.LargeChange = 1;
            this.trackBar_offset.Location = new System.Drawing.Point(6, 37);
            this.trackBar_offset.Maximum = 31;
            this.trackBar_offset.Minimum = -31;
            this.trackBar_offset.Name = "trackBar_offset";
            this.trackBar_offset.Size = new System.Drawing.Size(238, 45);
            this.trackBar_offset.TabIndex = 13;
            this.trackBar_offset.Scroll += new System.EventHandler(this.trackBar_offset_Scroll);
            // 
            // label_offset
            // 
            this.label_offset.AutoSize = true;
            this.label_offset.Location = new System.Drawing.Point(6, 21);
            this.label_offset.Name = "label_offset";
            this.label_offset.Size = new System.Drawing.Size(38, 13);
            this.label_offset.TabIndex = 13;
            this.label_offset.Text = "Offset:";
            // 
            // comboBox_edge_enhancement_mode
            // 
            this.comboBox_edge_enhancement_mode.FormattingEnabled = true;
            this.comboBox_edge_enhancement_mode.Location = new System.Drawing.Point(10, 191);
            this.comboBox_edge_enhancement_mode.Name = "comboBox_edge_enhancement_mode";
            this.comboBox_edge_enhancement_mode.Size = new System.Drawing.Size(160, 21);
            this.comboBox_edge_enhancement_mode.TabIndex = 20;
            this.comboBox_edge_enhancement_mode.SelectedIndexChanged += new System.EventHandler(this.comboBox_edge_enhancement_mode_SelectedIndexChanged);
            // 
            // label_edge_enhancement_mode
            // 
            this.label_edge_enhancement_mode.AutoSize = true;
            this.label_edge_enhancement_mode.Location = new System.Drawing.Point(6, 171);
            this.label_edge_enhancement_mode.Name = "label_edge_enhancement_mode";
            this.label_edge_enhancement_mode.Size = new System.Drawing.Size(151, 13);
            this.label_edge_enhancement_mode.TabIndex = 21;
            this.label_edge_enhancement_mode.Text = "E3: Edge enhancement mode:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 627);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_c0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_c1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_edge)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_vref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_offset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar_c1;
        private System.Windows.Forms.Label label_c1;
        private System.Windows.Forms.TrackBar trackBar_c0;
        private System.Windows.Forms.Label label_c0;
        private System.Windows.Forms.Label label_c0_value;
        private System.Windows.Forms.Label label_c1_value;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox_comport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_baud;
        private System.Windows.Forms.Label label_gain_value;
        private System.Windows.Forms.Label label_gain;
        private System.Windows.Forms.TrackBar trackBar_gain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trackBar_edge;
        private System.Windows.Forms.Label label_edge;
        private System.Windows.Forms.Label label_vhmode;
        private System.Windows.Forms.ComboBox comboBox_vhmode;
        private System.Windows.Forms.CheckBox checkBox_n;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox_x;
        private System.Windows.Forms.CheckBox checkBox_m;
        private System.Windows.Forms.CheckBox checkBox_p;
        private System.Windows.Forms.Label label_calibration_value;
        private System.Windows.Forms.Label label_calibration;
        private System.Windows.Forms.ComboBox comboBox_calibration;
        private System.Windows.Forms.CheckBox checkBox_inverted;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_vref_value;
        private System.Windows.Forms.TrackBar trackBar_vref;
        private System.Windows.Forms.Label label_vref;
        private System.Windows.Forms.Label label_offset_value;
        private System.Windows.Forms.TrackBar trackBar_offset;
        private System.Windows.Forms.Label label_offset;
        private System.Windows.Forms.Label label_edge_value;
        private System.Windows.Forms.Label label_vhmode_value;
        private System.Windows.Forms.Label label_edge_enhancement_mode;
        private System.Windows.Forms.ComboBox comboBox_edge_enhancement_mode;
    }
}

