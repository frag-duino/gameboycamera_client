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
        Boolean[,] data_save = new Boolean[8, 128 * 128];
        public int[] data_live_child = new int[128 * 128];
        byte tempbyte;

        protected override void OnPaint(PaintEventArgs e)
        {
            // Lock the bitmaps bits:
            Rectangle rect = new Rectangle(0, 0, bitmap_live_child.Width, bitmap_live_child.Height);
            BitmapData bmpData =
            bitmap_live_child.LockBits(rect, ImageLockMode.ReadWrite,
                         PixelFormat.Format24bppRgb);
            IntPtr ptr = bmpData.Scan0; // Get the address of the first line.

            // Declare an array to hold the bytes of the bitmap. (3 Byte per Pixel)
            int numBytes = bitmap_live_child.Width * bitmap_live_child.Height * 3; // RGB
            byte[] rgbValues = new byte[numBytes];

            for (int counter = 0; counter < data_live_child.Length; counter++)
            {
                tempbyte = Convert.ToByte(data_live_child[counter]);
                rgbValues[(counter * 3) + 0] = tempbyte;
                rgbValues[(counter * 3) + 1] = tempbyte;
                rgbValues[(counter * 3) + 2] = tempbyte;
            }

            Marshal.Copy(rgbValues, 0, ptr, numBytes); // Copy the RGB values back to the bitmap
            bitmap_live_child.UnlockBits(bmpData); // Unlock the bits.

            e.Graphics.DrawImage(bitmap_live_child, 10, 10); // Draw it
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

        private void Form_view_Load(object sender, EventArgs e)
        {

        }
    }
}
