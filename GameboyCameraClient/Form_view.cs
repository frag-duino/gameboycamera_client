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
    public partial class Form_view : Form
    {
        // UI
        Form1 parent;
        public Bitmap bitmap_live_child;
        public Graphics graph_live_child;
        public Bitmap[] bitmap_save = new Bitmap[3];
        public Graphics[] graph_save = new Graphics[3];
        public int[,] data_save = new int[3, 128 * 112];
        public String[] label_save = new String[3];

        byte tempbyte;
        
        protected override void OnPaint(PaintEventArgs e)
        {

            // ------------------------------------------
            // Draw the live image (512*448):
            // ------------------------------------------

            // Lock the bitmaps bits:
            Rectangle rect = new Rectangle(0, 0, bitmap_live_child.Width, bitmap_live_child.Height);
            BitmapData bmpData =
            bitmap_live_child.LockBits(rect, ImageLockMode.ReadWrite,
                         PixelFormat.Format24bppRgb);
            IntPtr ptr = bmpData.Scan0; // Get the address of the first line.

            // Declare an array to hold the bytes of the bitmap. (3 Byte per Pixel)
            int numBytes = bitmap_live_child.Width * bitmap_live_child.Height * 3; // RGB
            byte[] rgbValues = new byte[numBytes];

            // Scale the image by factor 4!
            for (int row = 0; row < 112; row++) // 112 rows
                for (int scaler_row = 0; scaler_row < 4; scaler_row++) // 4 times
                    for (int column = 0; column < 128; column++) // 128 pixels in a row
                    {
                        tempbyte = Convert.ToByte(parent.data[(row * 128) + column]);
                        for (int scaler_column = 0; scaler_column < 12; scaler_column++) // 12 Times (4columm * 3RGB)
                            rgbValues[((row * 4 + scaler_row) * 512 * 3) + (column * 12) + scaler_column] = tempbyte;
                    }


            Marshal.Copy(rgbValues, 0, ptr, numBytes); // Copy the RGB values back to the bitmap
            bitmap_live_child.UnlockBits(bmpData); // Unlock the bits.
            e.Graphics.DrawImage(bitmap_live_child, 44, 44); // Draw it


            // ------------------------------------------
            // Draw the first save image (256*224):
            // ------------------------------------------
            rect = new Rectangle(0, 0, bitmap_save[0].Width, bitmap_save[0].Height);
            numBytes = bitmap_save[0].Width * bitmap_save[0].Height * 3; // RGB
            rgbValues = new byte[numBytes];

            // Lock the bitmaps bits:
            bmpData =
            bitmap_save[0].LockBits(rect, ImageLockMode.ReadWrite,
                         PixelFormat.Format24bppRgb);
            ptr = bmpData.Scan0; // Get the address of the first line.

            // Scale the image by factor 2!
            for (int row = 0; row < 112; row++) // 112 rows
                for (int scaler_row = 0; scaler_row < 2; scaler_row++) // 4 times
                    for (int column = 0; column < 128; column++) // 128 pixels in a row
                    {
                        tempbyte = Convert.ToByte(data_save[0, (row * 128) + column]);
                        for (int scaler_column = 0; scaler_column < 6; scaler_column++) // 12 Times (2columm * 3RGB)
                            rgbValues[((row * 2 + scaler_row) * 256 * 3) + (column * 6) + scaler_column] = tempbyte;
                    }
            Marshal.Copy(rgbValues, 0, ptr, numBytes); // Copy the RGB values back to the bitmap
            bitmap_save[0].UnlockBits(bmpData); // Unlock the bits.
            e.Graphics.DrawImage(bitmap_save[0], 682, 44); // Right top    


            // ------------------------------------------
            // Draw the last 2 saved images (128*112):
            // ------------------------------------------
            rect = new Rectangle(0, 0, bitmap_save[1].Width, bitmap_save[1].Height);
            numBytes = bitmap_save[1].Width * bitmap_save[1].Height * 3; // RGB
            rgbValues = new byte[numBytes];

            for (int i = 1; i <= 2; i++) // 1+2
            {
                // Lock the bitmaps bits:
                bmpData =
                bitmap_save[i].LockBits(rect, ImageLockMode.ReadWrite,
                             PixelFormat.Format24bppRgb);
                ptr = bmpData.Scan0; // Get the address of the first line.

                // Scale the image by factor 1
                for (int row = 0; row < 112; row++) // 112 rows
                        for (int column = 0; column < 128; column++) // 128 pixels in a row
                        {
                            tempbyte = Convert.ToByte(data_save[i, (row * 128) + column]);
                            for (int scaler_column = 0; scaler_column < 3; scaler_column++) // 12 Times (2columm * 3RGB)
                                rgbValues[(row * 128 * 3) + (column * 3) + scaler_column] = tempbyte;
                        }
                Marshal.Copy(rgbValues, 0, ptr, numBytes); // Copy the RGB values back to the bitmap
                bitmap_save[i].UnlockBits(bmpData); // Unlock the bits.
                if (i == 1)
                    e.Graphics.DrawImage(bitmap_save[i], 640, 390); // Right bottom left
                else if (i == 2)
                    e.Graphics.DrawImage(bitmap_save[i], 852, 390); // Right bottom right
            }

            // Draw the labels:
            this.label_0.Text = label_save[0];
            this.label_1.Text = label_save[1];
            this.label_2.Text = label_save[2];
        }

        public Form_view(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosing += FormView_FormClosing;
            this.Click += FormView_Clicked;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // Create image:
            bitmap_live_child = new Bitmap(512, 448);
            graph_live_child = CreateGraphics();
            bitmap_save[0] = new Bitmap(256, 224);
            graph_save[0] = CreateGraphics();
            bitmap_save[1] = new Bitmap(128, 112);
            graph_save[1] = CreateGraphics();
            bitmap_save[2] = new Bitmap(128, 112);
            graph_save[2] = CreateGraphics();

            for (int i = 0; i < 3; i++)
                label_save[i] = "-";
        }

        private void FormView_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.view = null;
        }
    }
}
