namespace GameboyCameraClient
{
    partial class Form_view
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
            this.label_0 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.labelerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_0
            // 
            this.label_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_0.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_0.Location = new System.Drawing.Point(682, 310);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(256, 35);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "-";
            this.label_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_1
            // 
            this.label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_1.Location = new System.Drawing.Point(640, 528);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(128, 35);
            this.label_1.TabIndex = 1;
            this.label_1.Text = "-";
            this.label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_2
            // 
            this.label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_2.Location = new System.Drawing.Point(852, 528);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(128, 35);
            this.label_2.TabIndex = 2;
            this.label_2.Text = "-";
            this.label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerror.ForeColor = System.Drawing.Color.Red;
            this.labelerror.Location = new System.Drawing.Point(148, 566);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(112, 37);
            this.labelerror.TabIndex = 3;
            this.labelerror.Text = "Error?";
            // 
            // Form_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1136, 661);
            this.ControlBox = false;
            this.Controls.Add(this.labelerror);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.label_0);
            this.Name = "Form_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_view_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_0;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label labelerror;
    }
}