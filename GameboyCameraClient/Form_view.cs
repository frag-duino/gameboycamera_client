using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public Bitmap[] bitmap_save = new Bitmap[8];
        public Graphics[] graph_save = new Graphics[8];

        public Form_view(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosing += FormView_FormClosing;

            // Create image:
            bitmap_live_child = new Bitmap(512, 512);
   
            for (int i = 0; i < 8; i++)
            {
                bitmap_save[i] = new Bitmap(128, 128);
                graph_save[i] = CreateGraphics();
            }
            graph_live_child = CreateGraphics();
            // graph.DrawImage(bitmap_live, 10, 10);
        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.view = null;
        }
    }
}
