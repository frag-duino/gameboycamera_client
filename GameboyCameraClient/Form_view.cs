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
        public Bitmap bitmap_last_child;
        public Graphics graph_last_child;
        
        public Bitmap[] bitmap_save = new Bitmap[8];
        public Graphics[] graph_save = new Graphics[8];

        private Bitmap CreateBitmap(int width, int height, string s)
        {
            Bitmap bmp = new Bitmap(width, height);

            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Color.LightCoral), 0, 0, bmp.Width, bmp.Height);
            g.DrawRectangle(new Pen(Color.Green, 10), 5, 5, bmp.Width - 10, bmp.Height - 10);
            g.DrawLine(new Pen(Color.Yellow, 15), 0, 0, bmp.Width, bmp.Height);
            g.DrawLine(new Pen(Color.Yellow, 15), bmp.Width, 0, 0, bmp.Height);

            SizeF size = g.MeasureString(s, this.Font);
            g.DrawString(s, this.Font, new SolidBrush(Color.Black),
                         (bmp.Width - size.Width) / 2,
                         (bmp.Height - size.Height) / 2);
            g.Dispose();

            return bmp;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap bmp = CreateBitmap(128, 128, "Hi Mom!");
            e.Graphics.DrawImage(bmp, 0, 0);
            MakeMoreBlue(bmp);
            // Draw the modified image to the right of the original one
            e.Graphics.DrawImage(bmp, 10, 10);
            bmp.Dispose();

            // e.Graphics.DrawImage(bitmap_live_child)

        }

        private void MakeMoreBlue(Bitmap bmp)
        {
            // Specify a pixel format.
            PixelFormat pxf = PixelFormat.Format24bppRgb;

            // Lock the bitmap's bits.
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData =
            bmp.LockBits(rect, ImageLockMode.ReadWrite,
                         pxf);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            // int numBytes = bmp.Width * bmp.Height * 3;
            int numBytes = bmpData.Stride * bmp.Height;
            byte[] rgbValues = new byte[numBytes];

            // Copy the RGB values into the array.
            Marshal.Copy(ptr, rgbValues, 0, numBytes);

            // Manipulate the bitmap, such as changing the
            // blue value for every other pixel in the the bitmap.
            for (int counter = 0; counter < 128*128; counter++)
                rgbValues[counter] = (byte) parent.data[counter];

            // Copy the RGB values back to the bitmap
            Marshal.Copy(rgbValues, 0, ptr, numBytes);

            // Unlock the bits.
            bmp.UnlockBits(bmpData);
        }

        public Form_view(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosing += FormView_FormClosing;

            // Create image:
            bitmap_live_child = new Bitmap(512, 512);
            graph_live_child = CreateGraphics();

            bitmap_last_child = new Bitmap(512, 512);
            graph_last_child = CreateGraphics();

            for (int i = 0; i < 8; i++)
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
