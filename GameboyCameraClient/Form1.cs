using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace GameboyCameraClient
{
    public partial class Form1 : Form
    {
        // Variables
        public int set_gain = 0;
        public int set_vh = 3;
        public int set_n = 0;
        public int set_c1 = 8;
        public int set_c0 = 0;
        public int set_p = 1;
        public int set_m = 0;
        public int set_x = 1;
        public int set_vref = 3;
        public int set_i = 0;
        public int set_edge = 0;
        public byte set_offset = 0;
        public int set_z = 2;

        public Boolean haschanged_gain = true;
        public Boolean haschanged_vh = true;
        public Boolean haschanged_n = true;
        public Boolean haschanged_c1 = true;
        public Boolean haschanged_c0 = true;
        public Boolean haschanged_p = true;
        public Boolean haschanged_m = true;
        public Boolean haschanged_x = true;
        public Boolean haschanged_vref = true;
        public Boolean haschanged_i = true;
        public Boolean haschanged_edge = true;
        public Boolean haschanged_offset = true;
        public Boolean haschanged_z = true;
        public Boolean haschanged_colordepth = true;
        public Boolean haschanged_resolution = true;
        public Boolean haschanged_mode = true;

        // Image variables
        public int set_colordepth = Helper.COLORDEPTH_2BIT;
        public int set_resolution = Helper.RESOLUTION_128PX;
        public int set_mode = Helper.MODE_REGULAR;

        // Serial settings
        public String comport = "COM3";
        public int baud = 115200;

        // UI:
        public Form_view view;
        public Bitmap bitmap_live_parent;
        public Graphics graph_live_parent;
        public TextBox log;
        public Button bt_start, bt_stop;
        public int[] data = new int[128 * 128];
        byte tempbyte;

        // Threads
        GetThread get;
        Thread get_thread;
        public Boolean update_config = false; // Send the settings to the module

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            this.DoubleBuffered = true;

            // Load default values:
            trackBar_c1.Value = set_c1;
            trackBar_c1_Scroll(null, null);
            trackBar_c0.Value = set_c0;
            trackBar_c0_Scroll(null, null);
            trackBar_offset.Value = set_offset;
            trackBar_offset_Scroll(null, null);
            trackBar_vref.Value = set_vref;
            trackBar_vref_Scroll(null, null);
            trackBar_edge.Value = set_edge;
            trackBar_edge_Scroll(null, null);
            trackBar_gain.Value = set_gain;
            trackBar_gain_Scroll(null, null);

            textBox1.AppendText("Initialized\r\n");

            bt_refresh_Click(null, null); // Get the comports

            comboBox_baud.Items.Add(9600);
            comboBox_baud.Items.Add(115200);
            comboBox_baud.Items.Add(250000);
            comboBox_baud.SelectedIndex = 1; // 115200
            comboBox_baud_SelectedIndexChanged(null, null);

            comboBox_calibration.Items.Add(Helper.VALUERANGE_CALIBRATION[0]); // No calibration
            comboBox_calibration.Items.Add(Helper.VALUERANGE_CALIBRATION[1]); // Positive
            comboBox_calibration.Items.Add(Helper.VALUERANGE_CALIBRATION[2]); // Negative
            comboBox_calibration.SelectedIndex = 1;
            comboBox_calibration_SelectedIndexChanged(null, null);

            comboBox_vhmode.Items.Add(Helper.VALUERANGE_VHMODE[0]); // No edge
            comboBox_vhmode.Items.Add(Helper.VALUERANGE_VHMODE[1]); // Horizontal edge
            comboBox_vhmode.Items.Add(Helper.VALUERANGE_VHMODE[2]); // Vertical edge
            comboBox_vhmode.Items.Add(Helper.VALUERANGE_VHMODE[3]); // 2-d edge mode
            comboBox_vhmode.SelectedIndex = 3;
            comboBox_vhmode_SelectedIndexChanged(null, null);

            comboBox_edge_enhancement_mode.Items.Add(Helper.VALUERANGE_EDGE_ENHANCEMENT_MODE[0]);
            comboBox_edge_enhancement_mode.Items.Add(Helper.VALUERANGE_EDGE_ENHANCEMENT_MODE[1]);
            comboBox_edge_enhancement_mode.SelectedIndex = 0;
            comboBox_edge_enhancement_mode_SelectedIndexChanged(null, null);

            comboBox_resolution.Items.Add(Helper.VALUERANGE_RESOLUTION[0]); // 2Bit, 128x128
            comboBox_resolution.Items.Add(Helper.VALUERANGE_RESOLUTION[1]); // 8Bit, 32x32
            comboBox_resolution.Items.Add(Helper.VALUERANGE_RESOLUTION[2]); // 8Bit, 128x128
            comboBox_resolution.SelectedIndex = 0;
            comboBox_resolution_SelectedIndexChanged(null, null);

            checkBox_inverted_CheckedChanged(null, null);
            checkBox_n_CheckedChanged(null, null);
            checkBox_testmode_CheckedChanged(null, null);

            // Create image:
            bitmap_live_parent = new Bitmap(128, 128, PixelFormat.Format24bppRgb);
            graph_live_parent = CreateGraphics();
            
            log = textBox1;
            bt_start = button_start;
            bt_stop = button_stop;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (get != null)
                get.stopThread();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            get = new GetThread(this);
            get_thread = new Thread(new ThreadStart(get.getPhoto));
            get_thread.Start();
            bt_start.Enabled = false;
            bt_stop.Enabled = true;
        }

        private void trackBar_c1_Scroll(object sender, EventArgs e)
        {
            set_c1 = trackBar_c1.Value;
            label_c1_value.Text = set_c1 + " / " + Helper.getBinaryRepresentation(set_c1, 8);
            haschanged_c1 = true;
        }
        private void trackBar_c0_Scroll(object sender, EventArgs e)
        {
            set_c0 = trackBar_c0.Value;
            label_c0_value.Text = set_c0 + " / " + Helper.getBinaryRepresentation(set_c0, 8);
            haschanged_c0 = true;
        }

        private void comboBox_baud_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.baud = (int)comboBox_baud.Items[comboBox_baud.SelectedIndex];
            }
            catch (Exception ex) { textBox1.AppendText("Error Parsing Baud-Rate:\r\n" + ex + "\r\n\r\n"); }
        }

        private void trackBar_gain_Scroll(object sender, EventArgs e)
        {
            set_gain = trackBar_gain.Value;
            label_gain_value.Text = set_gain + " bel / " + Helper.getBinaryRepresentation(set_gain, 5);
            haschanged_gain = true;
        }

        private void trackBar_vref_Scroll(object sender, EventArgs e)
        {
            set_vref = trackBar_vref.Value;
            label_vref_value.Text = Helper.VALUERANGE_VREF[set_vref].ToString() + "V / " + Helper.getBinaryRepresentation(set_vref, 3);
            haschanged_vref = true;
        }

        private void comboBox_calibration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_calibration.SelectedIndex == 0)
                set_z = 0; // 00 = No Calibration
            else if (comboBox_calibration.SelectedIndex == 1)
                set_z = 2; // 10 = Positive
            else if (comboBox_calibration.SelectedIndex == 2)
                set_z = 1; // 01 = Negative

            label_calibration_value.Text = set_z.ToString() + " / " + Helper.getBinaryRepresentation(set_z, 2);
            haschanged_z = true;
        }

        private void trackBar_offset_Scroll(object sender, EventArgs e)
        {
            byte temp2 = (byte)trackBar_offset.Value;
            if (trackBar_offset.Value >= 0)
            {
                temp2 = (byte)(temp2 + ((byte)32));
                label_offset_value.Text = "+" + trackBar_offset.Value * 32 + " mV / " + Helper.getBinaryRepresentation(temp2, 6);
            }
            else if (trackBar_offset.Value < 0)
            {
                temp2 = (byte)((32 - temp2) - 32);
                label_offset_value.Text = trackBar_offset.Value * 32 + " mV / " + Helper.getBinaryRepresentation(temp2, 6);
            }
            set_offset = temp2;
            haschanged_offset = true;
        }

        private void checkBox_inverted_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_inverted.Checked)
                set_i = 1;
            else
                set_i = 0;
            haschanged_i = true;
        }

        private void checkBox_n_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_n.Checked)
                set_n = 1;
            else
                set_n = 0;
            haschanged_n = true;
        }

        private void checkBox_p_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p.Checked)
                set_p = 1;
            else
                set_p = 0;
            haschanged_p = true;
        }

        private void checkBox_m_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_m.Checked)
                set_m = 1;
            else
                set_m = 0;
            haschanged_m = true;
        }

        private void checkBox_x_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_x.Checked)
                set_x = 1;
            else
                set_x = 0;
            haschanged_x = true;
        }

        private void trackBar_edge_Scroll(object sender, EventArgs e)
        {
            set_edge = trackBar_edge.Value & 7; // & 0111
            if (comboBox_edge_enhancement_mode.SelectedIndex == 1)
                set_edge = set_edge | 8;

            label_edge_value.Text = Helper.VALUERANGE_EDGERATIO[trackBar_edge.Value] + "% / " + Helper.getBinaryRepresentation(set_edge, 4);
            haschanged_edge = true;
        }

        private void comboBox_vhmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_vh = comboBox_vhmode.SelectedIndex;
            label_vhmode_value.Text = set_vh + " / " + Helper.getBinaryRepresentation(set_vh, 2);
            haschanged_vh = true;
        }

        private void comboBox_edge_enhancement_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackBar_edge_Scroll(null, null);
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            get.stopThread();
            hasChangedALL(true);
        }

        private void comboBox_resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_resolution.SelectedIndex == 0) // 2Bit, 128x128
            {
                set_colordepth = Helper.COLORDEPTH_2BIT;
                set_resolution = Helper.RESOLUTION_128PX;
            }
            else if (comboBox_resolution.SelectedIndex == 1) // 8Bit,  32x32
            {
                set_colordepth = Helper.COLORDEPTH_8BIT;
                set_resolution = Helper.RESOLUTION_32PX;
            }
            else if (comboBox_resolution.SelectedIndex == 2) // 8Bit, 128x128
            {
                set_colordepth = Helper.COLORDEPTH_8BIT;
                set_resolution = Helper.RESOLUTION_128PX;
            }
            haschanged_resolution = true;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            log.Clear();
        }

        private void button_sendsettings_Click(object sender, EventArgs e)
        {
            update_config = true;
            textBox1.AppendText("Updating Config");
            hasChangedALL(true);
        }

        private void checkBox_testmode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_testmode.Checked)
                set_mode = Helper.MODE_TEST;
            else
                set_mode = Helper.MODE_REGULAR;
            haschanged_mode = true;
        }

        private void comboBox_comport_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comport = (String)comboBox_comport.Items[comboBox_comport.SelectedIndex];
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            comboBox_comport.Items.Clear();

            foreach (String s in SerialPort.GetPortNames())
                comboBox_comport.Items.Add(s);
            if (comboBox_comport.Items.Count == 0)
                textBox1.AppendText("Error: No COM-Port available");
            else {
                comboBox_comport.SelectedIndex = 0;
                comport = comboBox_comport.Items[0].ToString();
                if (comboBox_comport.Items.Count == 1)
                    comboBox_comport.Enabled = false;
                else
                    comboBox_comport.Enabled = true;
            }
        }

        private void button_newview_Click(object sender, EventArgs e)
        {
            view = new Form_view(this);
            view.Show();
        }

        public void hasChangedALL(Boolean value)
        {
            haschanged_gain = value;
            haschanged_vh = value;
            haschanged_n = value;
            haschanged_c1 = value;
            haschanged_c0 = value;
            haschanged_p = value;
            haschanged_m = value;
            haschanged_x = value;
            haschanged_vref = value;
            haschanged_i = value;
            haschanged_edge = value;
            haschanged_offset = value;
            haschanged_z = value;
            haschanged_colordepth = value;
            haschanged_resolution = value;
            haschanged_mode = value;
        }

        public void saveBitmap()
        {
            if (view != null)
            {
                // First shift the images to the right:
                for (int i = 7; i > 0; i--)
                {
                    //   view.bitmap_save[i] = (Bitmap)view.bitmap_save[i - 1];
                    //   view.graph_save[i].DrawImage(view.bitmap_save[i], i * 128, 295);
                }

                view.bitmap_save[0] = (Bitmap)bitmap_live_parent.Clone();
                view.graph_save[0].DrawImage(view.bitmap_save[0], 0, 512);

                view.bitmap_last_child = (Bitmap)view.bitmap_live_child.Clone();
                view.graph_last_child.DrawImage(view.bitmap_last_child, 512, 0);
            }

            bitmap_live_parent.Save("i:\\test.png", ImageFormat.Png);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Lock the bitmaps bits:
            Rectangle rect = new Rectangle(0, 0, bitmap_live_parent.Width, bitmap_live_parent.Height);
            BitmapData bmpData =
            bitmap_live_parent.LockBits(rect, ImageLockMode.ReadWrite,
                         PixelFormat.Format24bppRgb);
            IntPtr ptr = bmpData.Scan0; // Get the address of the first line.

            // Declare an array to hold the bytes of the bitmap. (3 Byte per Pixel)
            int numBytes = bitmap_live_parent.Width * bitmap_live_parent.Height * 3; // RGB
            byte[] rgbValues = new byte[numBytes];

            for (int counter = 0; counter < data.Length; counter++)
            {
                tempbyte = Convert.ToByte(data[counter]);
                rgbValues[(counter * 3) + 0] = tempbyte;
                rgbValues[(counter * 3) + 1] = tempbyte;
                rgbValues[(counter * 3) + 2] = tempbyte;
            }
            
            Marshal.Copy(rgbValues, 0, ptr, numBytes); // Copy the RGB values back to the bitmap
            bitmap_live_parent.UnlockBits(bmpData); // Unlock the bits.

            e.Graphics.DrawImage(bitmap_live_parent, 10, 10); // Draw it
        }
    }
}