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
        public Bitmap[] bitmap_save = new Bitmap[4];
        public Graphics[] graph_save = new Graphics[4];
        public int[,] data_save = new int[4, 128 * 128];

        byte tempbyte;
        const int scaling_factor_childview = 4; // 128x128 -> 512x512

        protected override void OnPaint(PaintEventArgs e)
        {

            // ------------------------------------------
            // Draw the live image:
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


            //for (int r = 0; r < scaling_factor_childview; r++)
            //for (int s = 0; s < scaling_factor_childview; s++)
            //parent.view.bitmap_live_child.SetPixel(column * scaling_factor_childview + s, row * scaling_factor_childview + r, c);

            for (int counter = 0; counter < parent.data.Length; counter++)
            {
                tempbyte = Convert.ToByte(parent.data[counter]);
                rgbValues[(counter * 3) + 0] = tempbyte;
                rgbValues[(counter * 3) + 1] = tempbyte;
                rgbValues[(counter * 3) + 2] = tempbyte;
            }
            Marshal.Copy(rgbValues, 0, ptr, numBytes); // Copy the RGB values back to the bitmap
            bitmap_live_child.UnlockBits(bmpData); // Unlock the bits.
            e.Graphics.DrawImage(bitmap_live_child, 10, 10); // Draw it


            // ------------------------------------------
            // Draw the last 4 images:
            // ------------------------------------------
            rect = new Rectangle(0, 0, bitmap_save[0].Width, bitmap_save[0].Height);
            numBytes = bitmap_save[0].Width * bitmap_save[0].Height * 3; // RGB
            byte[] rgbValues2 = new byte[numBytes];

            for (int i = 0; i < 4; i++)
            {
                // Lock the bitmaps bits:
                bmpData =
                bitmap_save[i].LockBits(rect, ImageLockMode.ReadWrite,
                             PixelFormat.Format24bppRgb);
                ptr = bmpData.Scan0; // Get the address of the first line.

                for (int counter = 0; counter < 128*128; counter++)
                {
                    tempbyte = Convert.ToByte(data_save[i, counter]);
                    rgbValues2[(counter * 3) + 0] = tempbyte;
                    rgbValues2[(counter * 3) + 1] = tempbyte;
                    rgbValues2[(counter * 3) + 2] = tempbyte;
                }
                Marshal.Copy(rgbValues2, 0, ptr, numBytes); // Copy the RGB values back to the bitmap
                bitmap_save[i].UnlockBits(bmpData); // Unlock the bits.
                e.Graphics.DrawImage(bitmap_save[i], 150*i, 300); // Draw it
            }
        }
        
        public Form_view(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosing += FormView_FormClosing;
            this.DoubleBuffered = true;

            // Create image:
            bitmap_live_child = new Bitmap(128, 128);
            graph_live_child = CreateGraphics();

            for (int i = 0; i < bitmap_save.Length; i++)
            {
                bitmap_save[i] = new Bitmap(128, 128);
                graph_save[i] = CreateGraphics();
            }
        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.view = null;
        }
    }
}
