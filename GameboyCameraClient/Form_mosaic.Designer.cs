namespace GameboyCameraClient
{
    partial class Form_mosaic
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
            this.log = new System.Windows.Forms.TextBox();
            this.label_output = new System.Windows.Forms.Label();
            this.label_input = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_run = new System.Windows.Forms.Button();
            this.bt_output = new System.Windows.Forms.Button();
            this.bt_input = new System.Windows.Forms.Button();
            this.input_images_per_line = new System.Windows.Forms.NumericUpDown();
            this.label_folder = new System.Windows.Forms.Label();
            this.checkBox_subdirectory = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.input_images_per_line)).BeginInit();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(11, 220);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(432, 182);
            this.log.TabIndex = 34;
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(181, 125);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(56, 13);
            this.label_output.TabIndex = 33;
            this.label_output.Text = "Undefined";
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(181, 64);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(56, 13);
            this.label_input.TabIndex = 32;
            this.label_input.Text = "Undefined";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "This tool generates a mosaic of all 128x112 input files";
            // 
            // bt_run
            // 
            this.bt_run.Enabled = false;
            this.bt_run.Location = new System.Drawing.Point(181, 189);
            this.bt_run.Name = "bt_run";
            this.bt_run.Size = new System.Drawing.Size(263, 25);
            this.bt_run.TabIndex = 28;
            this.bt_run.Text = "Run";
            this.bt_run.UseVisualStyleBackColor = true;
            this.bt_run.Click += new System.EventHandler(this.bt_run_Click);
            // 
            // bt_output
            // 
            this.bt_output.Location = new System.Drawing.Point(181, 94);
            this.bt_output.Name = "bt_output";
            this.bt_output.Size = new System.Drawing.Size(128, 25);
            this.bt_output.TabIndex = 27;
            this.bt_output.Text = "Output Imagepath";
            this.bt_output.UseVisualStyleBackColor = true;
            this.bt_output.Click += new System.EventHandler(this.bt_output_Click);
            // 
            // bt_input
            // 
            this.bt_input.Location = new System.Drawing.Point(181, 36);
            this.bt_input.Name = "bt_input";
            this.bt_input.Size = new System.Drawing.Size(128, 25);
            this.bt_input.TabIndex = 26;
            this.bt_input.Text = "Input Imagepath";
            this.bt_input.UseVisualStyleBackColor = true;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // input_images_per_line
            // 
            this.input_images_per_line.Location = new System.Drawing.Point(270, 163);
            this.input_images_per_line.Name = "input_images_per_line";
            this.input_images_per_line.Size = new System.Drawing.Size(64, 20);
            this.input_images_per_line.TabIndex = 36;
            this.input_images_per_line.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_folder
            // 
            this.label_folder.AutoSize = true;
            this.label_folder.Location = new System.Drawing.Point(183, 165);
            this.label_folder.Name = "label_folder";
            this.label_folder.Size = new System.Drawing.Size(81, 13);
            this.label_folder.TabIndex = 35;
            this.label_folder.Text = "Images per line:";
            // 
            // checkBox_subdirectory
            // 
            this.checkBox_subdirectory.AutoSize = true;
            this.checkBox_subdirectory.Checked = true;
            this.checkBox_subdirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_subdirectory.Location = new System.Drawing.Point(316, 41);
            this.checkBox_subdirectory.Name = "checkBox_subdirectory";
            this.checkBox_subdirectory.Size = new System.Drawing.Size(129, 17);
            this.checkBox_subdirectory.TabIndex = 37;
            this.checkBox_subdirectory.Text = "Include subdirectories";
            this.checkBox_subdirectory.UseVisualStyleBackColor = true;
            // 
            // Form_mosaic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 414);
            this.Controls.Add(this.checkBox_subdirectory);
            this.Controls.Add(this.input_images_per_line);
            this.Controls.Add(this.label_folder);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_run);
            this.Controls.Add(this.bt_output);
            this.Controls.Add(this.bt_input);
            this.Name = "Form_mosaic";
            this.Text = "Create mosaic";
            ((System.ComponentModel.ISupportInitialize)(this.input_images_per_line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_run;
        private System.Windows.Forms.Button bt_output;
        private System.Windows.Forms.Button bt_input;
        private System.Windows.Forms.NumericUpDown input_images_per_line;
        private System.Windows.Forms.Label label_folder;
        private System.Windows.Forms.CheckBox checkBox_subdirectory;
    }
}