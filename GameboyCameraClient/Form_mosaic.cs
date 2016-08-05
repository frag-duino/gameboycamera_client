using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameboyCameraClient
{
    public partial class Form_mosaic : Form
    {
        private String path_input = "undefined";
        private String path_output = "undefined";
        private int number_of_input_files, number_of_lines, number_of_images_per_line;
        private Bitmap[] bitmap_input;
        private Bitmap bitmap_output;
        private String currentFilename, currentImagePath;
        private Color tempColor;

        public Form_mosaic(Form1 parent)
        {
            InitializeComponent();
            path_input = parent.PATH_OF_IMAGES;
            label_input.Text = path_input;
            this.DoubleBuffered = true;
        }

        private void bt_run_Click(object sender, EventArgs e)
        {
            number_of_images_per_line = (int)input_images_per_line.Value;

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

            number_of_input_files = allFiles.Length;
            number_of_lines = (int)Math.Floor(allFiles.Length / input_images_per_line.Value);
            bitmap_output = new Bitmap((int)(128 * number_of_images_per_line), (int)(number_of_lines * 112));

            log.AppendText("Found " + number_of_input_files + " files\r\n");
            log.AppendText("Results in " + number_of_lines + " lines of " + number_of_images_per_line + "\r\n");
            log.AppendText("Resulting bitmap size: " + bitmap_output.Size.Width + "x" + bitmap_output.Size.Height + "\r\n");

            bitmap_input = new Bitmap[(int)number_of_images_per_line];

            for (int current_line = 0; current_line < number_of_lines; current_line++)
            {
                // Load all images from the current line:
                for (int current_image = 0; current_image < number_of_images_per_line; current_image++)
                {
                    currentImagePath = allFiles[current_line * number_of_images_per_line + current_image];
                    currentFilename = Path.GetFileNameWithoutExtension(currentImagePath);
                    bitmap_input[current_image] = (Bitmap)Image.FromFile(currentImagePath, true);

                    if (bitmap_input[current_image].Width != 128 || bitmap_input[current_image].Height != 112)
                    {
                        log.AppendText("Stopping, image is in not correct resolution: " + currentFilename);
                        return;
                    }
                }

                for (int current_image = 0; current_image < number_of_images_per_line; current_image++)
                {
                    for (int row = 0; row < 112; row++) // 112 rows
                        for (int column = 0; column < 128; column++) // 128 pixels in a row
                        {
                            tempColor = bitmap_input[current_image].GetPixel(column, row);
                            bitmap_output.SetPixel(column + current_image * 128, row + current_line * 112, tempColor);
                        }
                }
            }

            log.AppendText("Loaded all lines\r\n");

            try
            {   // Save the image:
                bitmap_output.Save(path_output + "\\mosaic.png", ImageFormat.Png);
                log.AppendText("Saved the file: "+ path_output + "\\mosaic.png\r\n");
            }
            catch (Exception ex)
            {
                log.AppendText("Could not save " + currentFilename + ": " + ex.ToString());
            }

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
