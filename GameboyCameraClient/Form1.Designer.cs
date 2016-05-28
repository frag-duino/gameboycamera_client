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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_c0minus = new System.Windows.Forms.Button();
            this.bt_c0plus = new System.Windows.Forms.Button();
            this.bt_c1minus = new System.Windows.Forms.Button();
            this.bt_c1plus = new System.Windows.Forms.Button();
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
            this.number_image = new System.Windows.Forms.NumericUpDown();
            this.number_folder = new System.Windows.Forms.NumericUpDown();
            this.label_image = new System.Windows.Forms.Label();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.label_folder = new System.Windows.Forms.Label();
            this.checkBox_testmode = new System.Windows.Forms.CheckBox();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
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
            this.bt_vrefminus = new System.Windows.Forms.Button();
            this.bt_vrefplus = new System.Windows.Forms.Button();
            this.bt_offsetminus = new System.Windows.Forms.Button();
            this.bt_offsetplus = new System.Windows.Forms.Button();
            this.bt_gainminus = new System.Windows.Forms.Button();
            this.bt_gainplus = new System.Windows.Forms.Button();
            this.chk_mirrored = new System.Windows.Forms.CheckBox();
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
            this.bt_setimage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_c0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gain)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_folder)).BeginInit();
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
            this.button_start.Location = new System.Drawing.Point(269, 2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(128, 25);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Listen";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_c0minus);
            this.groupBox1.Controls.Add(this.bt_c0plus);
            this.groupBox1.Controls.Add(this.bt_c1minus);
            this.groupBox1.Controls.Add(this.bt_c1plus);
            this.groupBox1.Controls.Add(this.label_c0_value);
            this.groupBox1.Controls.Add(this.label_c1_value);
            this.groupBox1.Controls.Add(this.label_c1);
            this.groupBox1.Controls.Add(this.trackBar_c0);
            this.groupBox1.Controls.Add(this.label_c0);
            this.groupBox1.Controls.Add(this.trackBar_c1);
            this.groupBox1.Location = new System.Drawing.Point(403, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 116);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Light";
            // 
            // bt_c0minus
            // 
            this.bt_c0minus.Location = new System.Drawing.Point(10, 80);
            this.bt_c0minus.Name = "bt_c0minus";
            this.bt_c0minus.Size = new System.Drawing.Size(20, 27);
            this.bt_c0minus.TabIndex = 24;
            this.bt_c0minus.Text = "-";
            this.bt_c0minus.UseVisualStyleBackColor = true;
            this.bt_c0minus.Click += new System.EventHandler(this.bt_c0minus_Click);
            // 
            // bt_c0plus
            // 
            this.bt_c0plus.Location = new System.Drawing.Point(362, 80);
            this.bt_c0plus.Name = "bt_c0plus";
            this.bt_c0plus.Size = new System.Drawing.Size(20, 27);
            this.bt_c0plus.TabIndex = 23;
            this.bt_c0plus.Text = "+";
            this.bt_c0plus.UseVisualStyleBackColor = true;
            this.bt_c0plus.Click += new System.EventHandler(this.bt_c0plus_Click);
            // 
            // bt_c1minus
            // 
            this.bt_c1minus.Location = new System.Drawing.Point(10, 32);
            this.bt_c1minus.Name = "bt_c1minus";
            this.bt_c1minus.Size = new System.Drawing.Size(20, 27);
            this.bt_c1minus.TabIndex = 22;
            this.bt_c1minus.Text = "-";
            this.bt_c1minus.UseVisualStyleBackColor = true;
            this.bt_c1minus.Click += new System.EventHandler(this.bt_c1minus_Click);
            // 
            // bt_c1plus
            // 
            this.bt_c1plus.Location = new System.Drawing.Point(362, 32);
            this.bt_c1plus.Name = "bt_c1plus";
            this.bt_c1plus.Size = new System.Drawing.Size(20, 27);
            this.bt_c1plus.TabIndex = 21;
            this.bt_c1plus.Text = "+";
            this.bt_c1plus.UseVisualStyleBackColor = true;
            this.bt_c1plus.Click += new System.EventHandler(this.bt_c1plus_Click);
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
            this.trackBar_c0.Location = new System.Drawing.Point(29, 80);
            this.trackBar_c0.Maximum = 255;
            this.trackBar_c0.Name = "trackBar_c0";
            this.trackBar_c0.Size = new System.Drawing.Size(327, 45);
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
            this.trackBar_c1.Location = new System.Drawing.Point(29, 32);
            this.trackBar_c1.Maximum = 255;
            this.trackBar_c1.Name = "trackBar_c1";
            this.trackBar_c1.Size = new System.Drawing.Size(327, 45);
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
            this.trackBar_gain.Location = new System.Drawing.Point(32, 229);
            this.trackBar_gain.Maximum = 31;
            this.trackBar_gain.Name = "trackBar_gain";
            this.trackBar_gain.Size = new System.Drawing.Size(119, 45);
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
            this.textBox1.Location = new System.Drawing.Point(15, 401);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(782, 52);
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
            this.groupBox2.Controls.Add(this.number_image);
            this.groupBox2.Controls.Add(this.number_folder);
            this.groupBox2.Controls.Add(this.label_image);
            this.groupBox2.Controls.Add(this.bt_refresh);
            this.groupBox2.Controls.Add(this.label_folder);
            this.groupBox2.Controls.Add(this.checkBox_testmode);
            this.groupBox2.Controls.Add(this.comboBox_baud);
            this.groupBox2.Controls.Add(this.comboBox_comport);
            this.groupBox2.Location = new System.Drawing.Point(15, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 141);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // number_image
            // 
            this.number_image.Location = new System.Drawing.Point(86, 108);
            this.number_image.Name = "number_image";
            this.number_image.Size = new System.Drawing.Size(64, 20);
            this.number_image.TabIndex = 22;
            this.number_image.ValueChanged += new System.EventHandler(this.number_image_ValueChanged);
            // 
            // number_folder
            // 
            this.number_folder.Location = new System.Drawing.Point(86, 82);
            this.number_folder.Name = "number_folder";
            this.number_folder.Size = new System.Drawing.Size(64, 20);
            this.number_folder.TabIndex = 21;
            this.number_folder.ValueChanged += new System.EventHandler(this.number_folder_ValueChanged);
            // 
            // label_image
            // 
            this.label_image.AutoSize = true;
            this.label_image.Location = new System.Drawing.Point(21, 111);
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(39, 13);
            this.label_image.TabIndex = 19;
            this.label_image.Text = "Image:";
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(86, 18);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(64, 48);
            this.bt_refresh.TabIndex = 12;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // label_folder
            // 
            this.label_folder.AutoSize = true;
            this.label_folder.Location = new System.Drawing.Point(21, 85);
            this.label_folder.Name = "label_folder";
            this.label_folder.Size = new System.Drawing.Size(39, 13);
            this.label_folder.TabIndex = 18;
            this.label_folder.Text = "Folder:";
            // 
            // checkBox_testmode
            // 
            this.checkBox_testmode.AutoSize = true;
            this.checkBox_testmode.Location = new System.Drawing.Point(254, 34);
            this.checkBox_testmode.Name = "checkBox_testmode";
            this.checkBox_testmode.Size = new System.Drawing.Size(77, 17);
            this.checkBox_testmode.TabIndex = 20;
            this.checkBox_testmode.Text = "Test-Mode";
            this.checkBox_testmode.UseVisualStyleBackColor = true;
            this.checkBox_testmode.CheckedChanged += new System.EventHandler(this.checkBox_testmode_CheckedChanged);
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Location = new System.Drawing.Point(6, 45);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(74, 21);
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
            this.groupBox5.Controls.Add(this.bt_vrefminus);
            this.groupBox5.Controls.Add(this.bt_vrefplus);
            this.groupBox5.Controls.Add(this.bt_offsetminus);
            this.groupBox5.Controls.Add(this.bt_offsetplus);
            this.groupBox5.Controls.Add(this.bt_gainminus);
            this.groupBox5.Controls.Add(this.bt_gainplus);
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
            // bt_vrefminus
            // 
            this.bt_vrefminus.Location = new System.Drawing.Point(7, 88);
            this.bt_vrefminus.Name = "bt_vrefminus";
            this.bt_vrefminus.Size = new System.Drawing.Size(20, 27);
            this.bt_vrefminus.TabIndex = 28;
            this.bt_vrefminus.Text = "-";
            this.bt_vrefminus.UseVisualStyleBackColor = true;
            this.bt_vrefminus.Click += new System.EventHandler(this.bt_vrefminus_Click);
            // 
            // bt_vrefplus
            // 
            this.bt_vrefplus.Location = new System.Drawing.Point(158, 88);
            this.bt_vrefplus.Name = "bt_vrefplus";
            this.bt_vrefplus.Size = new System.Drawing.Size(20, 27);
            this.bt_vrefplus.TabIndex = 29;
            this.bt_vrefplus.Text = "+";
            this.bt_vrefplus.UseVisualStyleBackColor = true;
            this.bt_vrefplus.Click += new System.EventHandler(this.bt_vrefplus_Click);
            // 
            // bt_offsetminus
            // 
            this.bt_offsetminus.Location = new System.Drawing.Point(6, 37);
            this.bt_offsetminus.Name = "bt_offsetminus";
            this.bt_offsetminus.Size = new System.Drawing.Size(20, 27);
            this.bt_offsetminus.TabIndex = 26;
            this.bt_offsetminus.Text = "-";
            this.bt_offsetminus.UseVisualStyleBackColor = true;
            this.bt_offsetminus.Click += new System.EventHandler(this.bt_offsetminus_Click);
            // 
            // bt_offsetplus
            // 
            this.bt_offsetplus.Location = new System.Drawing.Point(157, 37);
            this.bt_offsetplus.Name = "bt_offsetplus";
            this.bt_offsetplus.Size = new System.Drawing.Size(20, 27);
            this.bt_offsetplus.TabIndex = 27;
            this.bt_offsetplus.Text = "+";
            this.bt_offsetplus.UseVisualStyleBackColor = true;
            this.bt_offsetplus.Click += new System.EventHandler(this.bt_offsetplus_Click);
            // 
            // bt_gainminus
            // 
            this.bt_gainminus.Location = new System.Drawing.Point(6, 229);
            this.bt_gainminus.Name = "bt_gainminus";
            this.bt_gainminus.Size = new System.Drawing.Size(20, 27);
            this.bt_gainminus.TabIndex = 25;
            this.bt_gainminus.Text = "-";
            this.bt_gainminus.UseVisualStyleBackColor = true;
            this.bt_gainminus.Click += new System.EventHandler(this.bt_gainminus_Click);
            // 
            // bt_gainplus
            // 
            this.bt_gainplus.Location = new System.Drawing.Point(157, 229);
            this.bt_gainplus.Name = "bt_gainplus";
            this.bt_gainplus.Size = new System.Drawing.Size(20, 27);
            this.bt_gainplus.TabIndex = 25;
            this.bt_gainplus.Text = "+";
            this.bt_gainplus.UseVisualStyleBackColor = true;
            this.bt_gainplus.Click += new System.EventHandler(this.bt_gainplus_Click);
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
            this.trackBar_vref.Location = new System.Drawing.Point(32, 88);
            this.trackBar_vref.Maximum = 7;
            this.trackBar_vref.Name = "trackBar_vref";
            this.trackBar_vref.Size = new System.Drawing.Size(119, 45);
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
            this.trackBar_offset.Location = new System.Drawing.Point(32, 37);
            this.trackBar_offset.Maximum = 31;
            this.trackBar_offset.Minimum = -31;
            this.trackBar_offset.Name = "trackBar_offset";
            this.trackBar_offset.Size = new System.Drawing.Size(119, 45);
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
            this.button_stop.Location = new System.Drawing.Point(269, 30);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(128, 25);
            this.button_stop.TabIndex = 9;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(269, 117);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(128, 23);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "Clear log";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_sendsettings
            // 
            this.button_sendsettings.Location = new System.Drawing.Point(269, 58);
            this.button_sendsettings.Name = "button_sendsettings";
            this.button_sendsettings.Size = new System.Drawing.Size(128, 25);
            this.button_sendsettings.TabIndex = 11;
            this.button_sendsettings.Text = "Send all settings";
            this.button_sendsettings.UseVisualStyleBackColor = true;
            this.button_sendsettings.Click += new System.EventHandler(this.button_sendsettings_Click);
            // 
            // button_newview
            // 
            this.button_newview.Location = new System.Drawing.Point(269, 89);
            this.button_newview.Name = "button_newview";
            this.button_newview.Size = new System.Drawing.Size(128, 25);
            this.button_newview.TabIndex = 12;
            this.button_newview.Text = "New window";
            this.button_newview.UseVisualStyleBackColor = true;
            this.button_newview.Click += new System.EventHandler(this.button_newview_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(269, 146);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(128, 25);
            this.bt_save.TabIndex = 13;
            this.bt_save.Text = "Save config";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(269, 177);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(128, 25);
            this.bt_reset.TabIndex = 14;
            this.bt_reset.Text = "Reset config";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click_1);
            // 
            // bt_setimage
            // 
            this.bt_setimage.Location = new System.Drawing.Point(269, 209);
            this.bt_setimage.Name = "bt_setimage";
            this.bt_setimage.Size = new System.Drawing.Size(128, 25);
            this.bt_setimage.TabIndex = 15;
            this.bt_setimage.Text = "Set Imagepath";
            this.bt_setimage.UseVisualStyleBackColor = true;
            this.bt_setimage.Click += new System.EventHandler(this.bt_setimage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 461);
            this.Controls.Add(this.bt_setimage);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gameboy Camera Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_c0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gain)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_folder)).EndInit();
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
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_sendsettings;
        private System.Windows.Forms.CheckBox checkBox_testmode;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button button_newview;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Label label_folder;
        private System.Windows.Forms.Label label_image;
        private System.Windows.Forms.CheckBox chk_mirrored;
        private System.Windows.Forms.Button bt_c0minus;
        private System.Windows.Forms.Button bt_c0plus;
        private System.Windows.Forms.Button bt_c1minus;
        private System.Windows.Forms.Button bt_c1plus;
        private System.Windows.Forms.Button bt_gainminus;
        private System.Windows.Forms.Button bt_gainplus;
        private System.Windows.Forms.Button bt_offsetminus;
        private System.Windows.Forms.Button bt_offsetplus;
        private System.Windows.Forms.Button bt_vrefminus;
        private System.Windows.Forms.Button bt_vrefplus;
        private System.Windows.Forms.Button bt_setimage;
        private System.Windows.Forms.NumericUpDown number_folder;
        private System.Windows.Forms.NumericUpDown number_image;
    }
}

