namespace GameboyCameraClient
{
    partial class Form_scaler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_scaler));
            this.bt_input = new System.Windows.Forms.Button();
            this.bt_output = new System.Windows.Forms.Button();
            this.bt_run = new System.Windows.Forms.Button();
            this.comboBox_resolution = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_input = new System.Windows.Forms.Label();
            this.label_output = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TextBox();
            this.checkBox_subdirectory = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bt_input
            // 
            this.bt_input.Location = new System.Drawing.Point(182, 34);
            this.bt_input.Name = "bt_input";
            this.bt_input.Size = new System.Drawing.Size(128, 25);
            this.bt_input.TabIndex = 16;
            this.bt_input.Text = "Input Imagepath";
            this.bt_input.UseVisualStyleBackColor = true;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // bt_output
            // 
            this.bt_output.Location = new System.Drawing.Point(182, 92);
            this.bt_output.Name = "bt_output";
            this.bt_output.Size = new System.Drawing.Size(128, 25);
            this.bt_output.TabIndex = 17;
            this.bt_output.Text = "Output Imagepath";
            this.bt_output.UseVisualStyleBackColor = true;
            this.bt_output.Click += new System.EventHandler(this.bt_output_Click);
            // 
            // bt_run
            // 
            this.bt_run.Enabled = false;
            this.bt_run.Location = new System.Drawing.Point(182, 187);
            this.bt_run.Name = "bt_run";
            this.bt_run.Size = new System.Drawing.Size(263, 25);
            this.bt_run.TabIndex = 18;
            this.bt_run.Text = "Run";
            this.bt_run.UseVisualStyleBackColor = true;
            this.bt_run.Click += new System.EventHandler(this.bt_run_Click);
            // 
            // comboBox_resolution
            // 
            this.comboBox_resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_resolution.FormattingEnabled = true;
            this.comboBox_resolution.Location = new System.Drawing.Point(316, 160);
            this.comboBox_resolution.Name = "comboBox_resolution";
            this.comboBox_resolution.Size = new System.Drawing.Size(125, 21);
            this.comboBox_resolution.TabIndex = 19;
            this.comboBox_resolution.SelectedIndexChanged += new System.EventHandler(this.comboBox_resolution_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "This tool scales the images to the defined resolution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Output resolution:";
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(182, 62);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(56, 13);
            this.label_input.TabIndex = 22;
            this.label_input.Text = "Undefined";
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(182, 123);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(56, 13);
            this.label_output.TabIndex = 23;
            this.label_output.Text = "Undefined";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 218);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(432, 182);
            this.log.TabIndex = 24;
            // 
            // checkBox_subdirectory
            // 
            this.checkBox_subdirectory.AutoSize = true;
            this.checkBox_subdirectory.Checked = true;
            this.checkBox_subdirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_subdirectory.Location = new System.Drawing.Point(316, 39);
            this.checkBox_subdirectory.Name = "checkBox_subdirectory";
            this.checkBox_subdirectory.Size = new System.Drawing.Size(129, 17);
            this.checkBox_subdirectory.TabIndex = 25;
            this.checkBox_subdirectory.Text = "Include subdirectories";
            this.checkBox_subdirectory.UseVisualStyleBackColor = true;
            // 
            // Form_scaler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 412);
            this.Controls.Add(this.checkBox_subdirectory);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_resolution);
            this.Controls.Add(this.bt_run);
            this.Controls.Add(this.bt_output);
            this.Controls.Add(this.bt_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_scaler";
            this.Text = "Image Scaler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_input;
        private System.Windows.Forms.Button bt_output;
        private System.Windows.Forms.Button bt_run;
        private System.Windows.Forms.ComboBox comboBox_resolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.CheckBox checkBox_subdirectory;
    }
}