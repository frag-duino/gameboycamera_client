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
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_c0_value = new System.Windows.Forms.Label();
            this.label_c1_value = new System.Windows.Forms.Label();
            this.label_c1 = new System.Windows.Forms.Label();
            this.trackBar_c0 = new System.Windows.Forms.TrackBar();
            this.label_c0 = new System.Windows.Forms.Label();
            this.trackBar_c1 = new System.Windows.Forms.TrackBar();
            this.label_gain_value = new System.Windows.Forms.Label();
            this.label_gain = new System.Windows.Forms.Label();
            this.trackBar_gain = new System.Windows.Forms.TrackBar();
            this.label_calibration_value = new System.Windows.Forms.Label();
            this.label_calibration = new System.Windows.Forms.Label();
            this.comboBox_calibration = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox_comport = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.checkBox_testmode = new System.Windows.Forms.CheckBox();
            this.label_resolution = new System.Windows.Forms.Label();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.comboBox_resolution = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_edge_enhancement_mode = new System.Windows.Forms.Label();
            this.comboBox_edge_enhancement_mode = new System.Windows.Forms.ComboBox();
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
            this.button_stop = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_sendsettings = new System.Windows.Forms.Button();
            this.button_newview = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.textBox_folder = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.label_folder = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.bt_imagepath = new System.Windows.Forms.Button();
            this.chk_mirrored = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_c0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gain)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_edge)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_vref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_offset)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(13, 153);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(128, 25);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Listen";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_c0_value);
            this.groupBox1.Controls.Add(this.label_c1_value);
            this.groupBox1.Controls.Add(this.label_c1);
            this.groupBox1.Controls.Add(this.trackBar_c0);
            this.groupBox1.Controls.Add(this.label_c0);
            this.groupBox1.Controls.Add(this.trackBar_c1);
            this.groupBox1.Location = new System.Drawing.Point(147, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Light";
            // 
            // label_c0_value
            // 
            this.label_c0_value.AutoSize = true;
            this.label_c0_value.Location = new System.Drawing.Point(36, 64);
            this.label_c0_value.Name = "label_c0_value";
            this.label_c0_value.Size = new System.Drawing.Size(12, 13);
            this.label_c0_value.TabIndex = 5;
            this.label_c0_value.Text = "x";
            // 
            // label_c1_value
            // 
            this.label_c1_value.AutoSize = true;
            this.label_c1_value.Location = new System.Drawing.Point(36, 16);
            this.label_c1_value.Name = "label_c1_value";
            this.label_c1_value.Size = new System.Drawing.Size(12, 13);
            this.label_c1_value.TabIndex = 4;
            this.label_c1_value.Text = "x";
            // 
            // label_c1
            // 
            this.label_c1.AutoSize = true;
            this.label_c1.Location = new System.Drawing.Point(7, 16);
            this.label_c1.Name = "label_c1";
            this.label_c1.Size = new System.Drawing.Size(23, 13);
            this.label_c1.TabIndex = 3;
            this.label_c1.Text = "C1:";
            // 
            // trackBar_c0
            // 
            this.trackBar_c0.LargeChange = 1;
            this.trackBar_c0.Location = new System.Drawing.Point(10, 80);
            this.trackBar_c0.Maximum = 255;
            this.trackBar_c0.Name = "trackBar_c0";
            this.trackBar_c0.Size = new System.Drawing.Size(231, 45);
            this.trackBar_c0.TabIndex = 2;
            this.trackBar_c0.Scroll += new System.EventHandler(this.trackBar_c0_Scroll);
            // 
            // label_c0
            // 
            this.label_c0.AutoSize = true;
            this.label_c0.Location = new System.Drawing.Point(7, 64);
            this.label_c0.Name = "label_c0";
            this.label_c0.Size = new System.Drawing.Size(26, 13);
            this.label_c0.TabIndex = 1;
            this.label_c0.Text = "C0: ";
            // 
            // trackBar_c1
            // 
            this.trackBar_c1.LargeChange = 1;
            this.trackBar_c1.Location = new System.Drawing.Point(12, 32);
            this.trackBar_c1.Maximum = 255;
            this.trackBar_c1.Name = "trackBar_c1";
            this.trackBar_c1.Size = new System.Drawing.Size(231, 45);
            this.trackBar_c1.TabIndex = 0;
            this.trackBar_c1.Scroll += new System.EventHandler(this.trackBar_c1_Scroll);
            // 
            // label_gain_value
            // 
            this.label_gain_value.AutoSize = true;
            this.label_gain_value.Location = new System.Drawing.Point(35, 213);
            this.label_gain_value.Name = "label_gain_value";
            this.label_gain_value.Size = new System.Drawing.Size(12, 13);
            this.label_gain_value.TabIndex = 8;
            this.label_gain_value.Text = "x";
            // 
            // label_gain
            // 
            this.label_gain.AutoSize = true;
            this.label_gain.Location = new System.Drawing.Point(6, 213);
            this.label_gain.Name = "label_gain";
            this.label_gain.Size = new System.Drawing.Size(32, 13);
            this.label_gain.TabIndex = 7;
            this.label_gain.Text = "Gain:";
            // 
            // trackBar_gain
            // 
            this.trackBar_gain.LargeChange = 1;
            this.trackBar_gain.Location = new System.Drawing.Point(9, 229);
            this.trackBar_gain.Maximum = 31;
            this.trackBar_gain.Name = "trackBar_gain";
            this.trackBar_gain.Size = new System.Drawing.Size(168, 45);
            this.trackBar_gain.TabIndex = 6;
            this.trackBar_gain.Scroll += new System.EventHandler(this.trackBar_gain_Scroll);
            // 
            // label_calibration_value
            // 
            this.label_calibration_value.AutoSize = true;
            this.label_calibration_value.Location = new System.Drawing.Point(89, 163);
            this.label_calibration_value.Name = "label_calibration_value";
            this.label_calibration_value.Size = new System.Drawing.Size(12, 13);
            this.label_calibration_value.TabIndex = 12;
            this.label_calibration_value.Text = "x";
            // 
            // label_calibration
            // 
            this.label_calibration.AutoSize = true;
            this.label_calibration.Location = new System.Drawing.Point(6, 163);
            this.label_calibration.Name = "label_calibration";
            this.label_calibration.Size = new System.Drawing.Size(78, 13);
            this.label_calibration.TabIndex = 11;
            this.label_calibration.Text = "Calibration (Z): ";
            // 
            // comboBox_calibration
            // 
            this.comboBox_calibration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_calibration.FormattingEnabled = true;
            this.comboBox_calibration.Location = new System.Drawing.Point(17, 179);
            this.comboBox_calibration.Name = "comboBox_calibration";
            this.comboBox_calibration.Size = new System.Drawing.Size(160, 21);
            this.comboBox_calibration.TabIndex = 10;
            this.comboBox_calibration.SelectedIndexChanged += new System.EventHandler(this.comboBox_calibration_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 285);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(650, 168);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox_comport
            // 
            this.comboBox_comport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comport.FormattingEnabled = true;
            this.comboBox_comport.Location = new System.Drawing.Point(6, 18);
            this.comboBox_comport.Name = "comboBox_comport";
            this.comboBox_comport.Size = new System.Drawing.Size(74, 21);
            this.comboBox_comport.TabIndex = 4;
            this.comboBox_comport.SelectedIndexChanged += new System.EventHandler(this.comboBox_comport_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_refresh);
            this.groupBox2.Controls.Add(this.checkBox_testmode);
            this.groupBox2.Controls.Add(this.label_resolution);
            this.groupBox2.Controls.Add(this.comboBox_baud);
            this.groupBox2.Controls.Add(this.comboBox_comport);
            this.groupBox2.Controls.Add(this.comboBox_resolution);
            this.groupBox2.Location = new System.Drawing.Point(147, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 135);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial";
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(86, 18);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(74, 21);
            this.bt_refresh.TabIndex = 12;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // checkBox_testmode
            // 
            this.checkBox_testmode.AutoSize = true;
            this.checkBox_testmode.Location = new System.Drawing.Point(6, 108);
            this.checkBox_testmode.Name = "checkBox_testmode";
            this.checkBox_testmode.Size = new System.Drawing.Size(77, 17);
            this.checkBox_testmode.TabIndex = 20;
            this.checkBox_testmode.Text = "Test-Mode";
            this.checkBox_testmode.UseVisualStyleBackColor = true;
            this.checkBox_testmode.CheckedChanged += new System.EventHandler(this.checkBox_testmode_CheckedChanged);
            // 
            // label_resolution
            // 
            this.label_resolution.AutoSize = true;
            this.label_resolution.Location = new System.Drawing.Point(3, 48);
            this.label_resolution.Name = "label_resolution";
            this.label_resolution.Size = new System.Drawing.Size(60, 13);
            this.label_resolution.TabIndex = 19;
            this.label_resolution.Text = "Resolution:";
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Location = new System.Drawing.Point(169, 18);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(74, 21);
            this.comboBox_baud.TabIndex = 5;
            this.comboBox_baud.SelectedIndexChanged += new System.EventHandler(this.comboBox_baud_SelectedIndexChanged);
            // 
            // comboBox_resolution
            // 
            this.comboBox_resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_resolution.FormattingEnabled = true;
            this.comboBox_resolution.Location = new System.Drawing.Point(6, 70);
            this.comboBox_resolution.Name = "comboBox_resolution";
            this.comboBox_resolution.Size = new System.Drawing.Size(238, 21);
            this.comboBox_resolution.TabIndex = 18;
            this.comboBox_resolution.SelectedIndexChanged += new System.EventHandler(this.comboBox_resolution_SelectedIndexChanged);
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
            this.groupBox3.Location = new System.Drawing.Point(593, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 222);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edge extraction";
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
            // comboBox_edge_enhancement_mode
            // 
            this.comboBox_edge_enhancement_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_edge_enhancement_mode.FormattingEnabled = true;
            this.comboBox_edge_enhancement_mode.Location = new System.Drawing.Point(10, 191);
            this.comboBox_edge_enhancement_mode.Name = "comboBox_edge_enhancement_mode";
            this.comboBox_edge_enhancement_mode.Size = new System.Drawing.Size(160, 21);
            this.comboBox_edge_enhancement_mode.TabIndex = 20;
            this.comboBox_edge_enhancement_mode.SelectedIndexChanged += new System.EventHandler(this.comboBox_edge_enhancement_mode_SelectedIndexChanged);
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
            this.comboBox_vhmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.groupBox4.Location = new System.Drawing.Point(593, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 49);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "1-D filtering kernel";
            // 
            // checkBox_x
            // 
            this.checkBox_x.AutoSize = true;
            this.checkBox_x.Checked = true;
            this.checkBox_x.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_x.Location = new System.Drawing.Point(141, 21);
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
            this.checkBox_m.Location = new System.Drawing.Point(88, 21);
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
            this.checkBox_p.Location = new System.Drawing.Point(12, 21);
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
            this.groupBox5.Controls.Add(this.chk_mirrored);
            this.groupBox5.Controls.Add(this.label_gain_value);
            this.groupBox5.Controls.Add(this.label_calibration_value);
            this.groupBox5.Controls.Add(this.label_gain);
            this.groupBox5.Controls.Add(this.checkBox_inverted);
            this.groupBox5.Controls.Add(this.trackBar_gain);
            this.groupBox5.Controls.Add(this.label_calibration);
            this.groupBox5.Controls.Add(this.label_vref_value);
            this.groupBox5.Controls.Add(this.comboBox_calibration);
            this.groupBox5.Controls.Add(this.trackBar_vref);
            this.groupBox5.Controls.Add(this.label_vref);
            this.groupBox5.Controls.Add(this.label_offset_value);
            this.groupBox5.Controls.Add(this.trackBar_offset);
            this.groupBox5.Controls.Add(this.label_offset);
            this.groupBox5.Location = new System.Drawing.Point(403, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(184, 277);
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
            this.trackBar_vref.Size = new System.Drawing.Size(171, 45);
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
            this.label_offset_value.Location = new System.Drawing.Point(71, 21);
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
            this.trackBar_offset.Size = new System.Drawing.Size(171, 45);
            this.trackBar_offset.TabIndex = 13;
            this.trackBar_offset.Scroll += new System.EventHandler(this.trackBar_offset_Scroll);
            // 
            // label_offset
            // 
            this.label_offset.AutoSize = true;
            this.label_offset.Location = new System.Drawing.Point(6, 21);
            this.label_offset.Name = "label_offset";
            this.label_offset.Size = new System.Drawing.Size(55, 13);
            this.label_offset.TabIndex = 13;
            this.label_offset.Text = "Offset (O):";
            // 
            // button_stop
            // 
            this.button_stop.Enabled = false;
            this.button_stop.Location = new System.Drawing.Point(13, 181);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(128, 25);
            this.button_stop.TabIndex = 9;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(13, 285);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(128, 23);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "Clear log";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_sendsettings
            // 
            this.button_sendsettings.Location = new System.Drawing.Point(13, 209);
            this.button_sendsettings.Name = "button_sendsettings";
            this.button_sendsettings.Size = new System.Drawing.Size(128, 25);
            this.button_sendsettings.TabIndex = 11;
            this.button_sendsettings.Text = "Send all settings";
            this.button_sendsettings.UseVisualStyleBackColor = true;
            this.button_sendsettings.Click += new System.EventHandler(this.button_sendsettings_Click);
            // 
            // button_newview
            // 
            this.button_newview.Location = new System.Drawing.Point(13, 240);
            this.button_newview.Name = "button_newview";
            this.button_newview.Size = new System.Drawing.Size(128, 25);
            this.button_newview.TabIndex = 12;
            this.button_newview.Text = "New window";
            this.button_newview.UseVisualStyleBackColor = true;
            this.button_newview.Click += new System.EventHandler(this.button_newview_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(13, 314);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(128, 25);
            this.bt_save.TabIndex = 13;
            this.bt_save.Text = "Save config";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(13, 345);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(128, 25);
            this.bt_reset.TabIndex = 14;
            this.bt_reset.Text = "Reset config";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click_1);
            // 
            // textBox_folder
            // 
            this.textBox_folder.Location = new System.Drawing.Point(77, 407);
            this.textBox_folder.Name = "textBox_folder";
            this.textBox_folder.Size = new System.Drawing.Size(64, 20);
            this.textBox_folder.TabIndex = 16;
            this.textBox_folder.TextChanged += new System.EventHandler(this.textBox_folder_TextChanged);
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(77, 433);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(64, 20);
            this.textBox_number.TabIndex = 17;
            this.textBox_number.TextChanged += new System.EventHandler(this.textBox_number_TextChanged);
            // 
            // label_folder
            // 
            this.label_folder.AutoSize = true;
            this.label_folder.Location = new System.Drawing.Point(12, 410);
            this.label_folder.Name = "label_folder";
            this.label_folder.Size = new System.Drawing.Size(39, 13);
            this.label_folder.TabIndex = 18;
            this.label_folder.Text = "Folder:";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(12, 436);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(47, 13);
            this.label_number.TabIndex = 19;
            this.label_number.Text = "Number:";
            // 
            // bt_imagepath
            // 
            this.bt_imagepath.Location = new System.Drawing.Point(13, 376);
            this.bt_imagepath.Name = "bt_imagepath";
            this.bt_imagepath.Size = new System.Drawing.Size(128, 25);
            this.bt_imagepath.TabIndex = 20;
            this.bt_imagepath.Text = "Set Imagepath";
            this.bt_imagepath.UseVisualStyleBackColor = true;
            // 
            // chk_mirrored
            // 
            this.chk_mirrored.AutoSize = true;
            this.chk_mirrored.Checked = true;
            this.chk_mirrored.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_mirrored.Location = new System.Drawing.Point(103, 135);
            this.chk_mirrored.Name = "chk_mirrored";
            this.chk_mirrored.Size = new System.Drawing.Size(64, 17);
            this.chk_mirrored.TabIndex = 18;
            this.chk_mirrored.Text = "Mirrored";
            this.chk_mirrored.UseVisualStyleBackColor = true;
            this.chk_mirrored.CheckedChanged += new System.EventHandler(this.chk_mirrored_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 461);
            this.Controls.Add(this.bt_imagepath);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label_folder);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.textBox_folder);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.button_newview);
            this.Controls.Add(this.button_sendsettings);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.Text = "Gameboy Camera Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_c0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gain)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button button_start;
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
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label_resolution;
        private System.Windows.Forms.ComboBox comboBox_resolution;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_sendsettings;
        private System.Windows.Forms.CheckBox checkBox_testmode;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button button_newview;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.TextBox textBox_folder;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Label label_folder;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Button bt_imagepath;
        private System.Windows.Forms.CheckBox chk_mirrored;
    }
}

