using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameboyCameraClient
{
    public partial class Form_scaler : Form
    {
        private const String RESOLUTION2_256x224 = "256 * 224";
        private const String RESOLUTION4_512x448 = "512 * 448";
        private const String RESOLUTION8_1024x896 = "1024 * 896";
        private const String RESOLUTION16_2048x1792 = "2048 * 1792";

        private String path_input = "undefined";
        private String path_output = "undefined";

        private int scale_factor = 4;

        private Bitmap bitmap_input, bitmap_output;
        private int counterImage = 0;
        private Color tempColor;
        private String currentFilename;
        
        public Form_scaler(Form1 parent)
        {
            InitializeComponent();
            path_input = parent.PATH_OF_IMAGES;
            label_input.Text = path_input;
            this.DoubleBuffered = true;

            comboBox_resolution.Items.Add(RESOLUTION2_256x224);
            comboBox_resolution.Items.Add(RESOLUTION4_512x448);
            comboBox_resolution.Items.Add(RESOLUTION8_1024x896);
            comboBox_resolution.Items.Add(RESOLUTION16_2048x1792);
            comboBox_resolution.SelectedIndex = 1;
            comboBox_resolution_SelectedIndexChanged(null, null);
        }

        private void bt_run_Click(object sender, EventArgs e)
        {
            counterImage = 0;
            string[] allFiles;
            try
            {
                if (checkBox_subdirectory.Checked)
                    allFiles = Directory.GetFiles(path_input, "*.png", SearchOption.AllDirectories);
                else
                    allFiles = Directory.GetFiles(path_input, "*.png", SearchOption.TopDirectoryOnly);
            }
            catch (DirectoryNotFoundException)
            {
                log.AppendText("Aborting, directory not found: " + path_input);
                return;
            }

            foreach (String currentImagePath in allFiles)
            {
                counterImage++;
                currentFilename = Path.GetFileNameWithoutExtension(currentImagePath);

                bitmap_input = (Bitmap)Image.FromFile(currentImagePath, true);
                if (bitmap_input.Width == 128 && bitmap_input.Height == 112)
                    log.AppendText("Scaling image " + counterImage + ": " + currentFilename + "\r\n");
                else
                {
                    log.AppendText("Skipping image " + counterImage + ": " + currentFilename + " (Wrong resolution)\r\n");
                    continue;
                }

                // Create a new bitmap with the new boundaries:
                bitmap_output = new Bitmap(bitmap_input.Width * scale_factor, bitmap_input.Height * scale_factor);

                // Scale the image by the scale-factor
                for (int row = 0; row < 112; row++) // 112 rows
                    for (int scaler_row = 0; scaler_row < scale_factor; scaler_row++)
                        for (int column = 0; column < 128; column++) // 128 pixels in a row
                        {
                            tempColor = bitmap_input.GetPixel(column, row);
                            for (int scaler_column = 0; scaler_column < scale_factor; scaler_column++)
                                bitmap_output.SetPixel(column * scale_factor + scaler_column, row * scale_factor + scaler_row, tempColor);
                        }
                try
                {
                    // Save the image:
                    bitmap_output.Save(path_output + "\\" + currentFilename + "_" + bitmap_output.Width + "x" + bitmap_output.Height + ".png", ImageFormat.Png);
                }
                catch (Exception ex)
                {
                    log.AppendText("Could not save " + currentFilename + ": " + ex.ToString());
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (bitmap_input != null)
                e.Graphics.DrawImage(bitmap_input, 10, 10);
        }

        private void comboBox_resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_resolution.SelectedIndex == 0)
                scale_factor = 2;
            else if (comboBox_resolution.SelectedIndex == 1)
                scale_factor = 4;
            else if (comboBox_resolution.SelectedIndex == 2)
                scale_factor = 8;
            else if (comboBox_resolution.SelectedIndex == 3)
                scale_factor = 16;
        }

        private void bt_input_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path_input = folderBrowserDialog1.SelectedPath;
                label_input.Text = path_input;
            }
            if (path_input.Equals("undefined") || path_output.Equals("undefined"))
                bt_run.Enabled = false;
            else
                bt_run.Enabled = true;
        }

        private void bt_output_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path_output = folderBrowserDialog1.SelectedPath;
                label_output.Text = path_output;
            }
            if (path_input.Equals("undefined") || path_output.Equals("undefined"))
                bt_run.Enabled = false;
            else
                bt_run.Enabled = true;
        }
    }
}
