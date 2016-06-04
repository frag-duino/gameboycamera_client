using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameboyCameraClient
{
    public partial class Form_scaler : Form
    {
        private String RESOLUTION2_256x224 = "256 * 224";
        private String RESOLUTION4_512x448 = "512 * 448";
        private String RESOLUTION8_1024x896 = "1024 * 896";
        private String path_input = "";
        private String path_output = "";

        private int target_resolution = 4;

        public Bitmap bitmap_input, bitmap_output;
        private String currentImage = "";
        private int counterImage = 0;
        private Color tempColor;

        public Form_scaler()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            comboBox_resolution.Items.Add(RESOLUTION2_256x224);
            comboBox_resolution.Items.Add(RESOLUTION4_512x448);
            comboBox_resolution.Items.Add(RESOLUTION8_1024x896);
            comboBox_resolution.SelectedIndex = 1;
            comboBox_resolution_SelectedIndexChanged(null, null);
        }

        private void bt_run_Click(object sender, EventArgs e)
        {
            currentImage = path_input + "\\test.png";
            counterImage++;
            bitmap_input = (Bitmap)Image.FromFile(currentImage, true);
            if (bitmap_input.Width == 128 && bitmap_input.Height == 112)
                log.AppendText("Processing image " + counterImage + ": " + currentImage + "\r\n");
            else
            {
                log.AppendText("Skipping image " + counterImage + ":" + currentImage + " ( Wrong resolution)\r\n");
                return;
            }

            int target_width = 512;
            int target_heigth = 448;

            bitmap_output = new Bitmap(target_width, target_heigth);

            // Scale the image by factor 4!
            for (int row = 0; row < 112; row++) // 112 rows
                for (int scaler_row = 0; scaler_row < 4; scaler_row++) // 4 times
                    for (int column = 0; column < 128; column++) // 128 pixels in a row
                    {
                        tempColor = bitmap_input.GetPixel(column, row);
                        for (int scaler_column = 0; scaler_column < 4; scaler_column++) // 4 Times
                            bitmap_output.SetPixel(column * 4 + scaler_column, row * 4 + scaler_row, tempColor);
                    }

            bitmap_output.Save(path_input + "\\out.png", ImageFormat.Png);
           
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (bitmap_input != null)
                e.Graphics.DrawImage(bitmap_input, 10, 10);
        }

        private void comboBox_resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_resolution.SelectedIndex == 0)
                target_resolution = 2;
            else if (comboBox_resolution.SelectedIndex == 1)
                target_resolution = 4;
            else if (comboBox_resolution.SelectedIndex == 2)
                target_resolution = 8;
        }

        private void bt_input_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path_input = folderBrowserDialog1.SelectedPath;
                label_input.Text = path_input;
            }
        }

        private void bt_output_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path_output = folderBrowserDialog1.SelectedPath;
                label_output.Text = path_output;
            }
        }
    }
}
