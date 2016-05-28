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
        static int default_gain = 0;
        static int default_vh = 3;
        static int default_n = 0;
        static int default_c1 = 8;
        static int default_c0 = 0;
        static int default_p = 1;
        static int default_m = 0;
        static int default_x = 1;
        static int default_vref = 3;
        static int default_i = 0;
        static int default_edge = 0;
        static byte default_offset = 0;
        static int default_z = 2;
        static int default_mirrored = 1;

        // Variables
        public int set_gain = default_gain;
        public int set_vh = default_vh;
        public int set_n = default_n;
        public int set_c1 = default_c1;
        public int set_c0 = default_c0;
        public int set_p = default_p;
        public int set_m = default_m;
        public int set_x = default_x;
        public int set_vref = default_vref;
        public int set_i = default_i;
        public int set_edge = default_edge;
        public byte set_offset = default_offset;
        public int set_z = default_z;

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
        public int set_mirrored = default_mirrored;
        public Boolean haschanged_edge = true;
        public Boolean haschanged_offset = true;
        public Boolean haschanged_z = true;
        public Boolean haschanged_colordepth = true;
        public Boolean haschanged_resolution = true;
        public Boolean haschanged_mode = true;

        // Image variables
        static int default_mode = Helper.MODE_REGULAR;
        public int set_mode = default_mode;

        // Serial settings
        public String comport = "";
        public int baud = 115200;

        // UI:
        public Form_view view;
        public Bitmap bitmap_live_parent;
        public Graphics graph_live_parent;
        public TextBox log;
        public Button bt_start, bt_stop;
        public NumericUpDown nb_folder, nb_image;
        public int[] data = new int[128 * 128];
        public TrackBar tb_offset;
        byte tempbyte;

        // Threads
        GetThread get;
        Thread get_thread;
        public Boolean update_config = false; // Send the settings to the module

        // Saving
        Configuration config;
        public String PATH_OF_IMAGES;
        public decimal currentFolder = 0;
        public decimal currentImage = 0;
        public String filename;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            this.DoubleBuffered = true;
            this.Click += Form_Clicked;
            tb_offset = this.trackBar_offset;
            log = textBox1;

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
                       
            config = new Configuration(this);
            loadValues();

            bt_refresh_Click(null, null); // Get the comports

            comboBox_baud.Items.Add(9600);
            comboBox_baud.Items.Add(115200);
            comboBox_baud.Items.Add(250000);
            comboBox_baud.SelectedIndex = 1; // 115200
            comboBox_baud_SelectedIndexChanged(null, null);

            number_folder.Value = currentFolder;
            number_image.Value = currentImage;

            // Create image:
            bitmap_live_parent = new Bitmap(256, 224, PixelFormat.Format24bppRgb);
            graph_live_parent = CreateGraphics();
            bt_start = button_start;
            bt_stop = button_stop;
            nb_folder = number_folder;
            nb_image = number_image;
        }
        
        private void loadValues()
        {
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

            checkBox_inverted_CheckedChanged(null, null);
            chk_mirrored_CheckedChanged(null, null);
            checkBox_n_CheckedChanged(null, null);
            checkBox_testmode_CheckedChanged(null, null);

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (get != null)
                get.stopThread();
            config.save_config();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            get = new GetThread(this);
            get_thread = new Thread(new ThreadStart(get.getPhoto));
            get_thread.Start();
            bt_start.Enabled = false;
            bt_stop.Enabled = true;
            number_folder.Enabled = false;
            number_image.Enabled = false;
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

        public void trackBar_offset_Scroll(object sender, EventArgs e)
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

        private void bt_reset_Click_1(object sender, EventArgs e)
        {
            // Variables
            set_gain = default_gain;
            set_vh = default_vh;
            set_n = default_n;
            set_c1 = default_c1;
            set_c0 = default_c0;
            set_p = default_p;
            set_m = default_m;
            set_x = default_x;
            set_vref = default_vref;
            set_i = default_i;
            set_edge = default_edge;
            set_offset = default_offset;
            set_z = default_z;

            // Image variables
            set_mode = default_mode;
            loadValues();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            config.save_config();
            log.AppendText("Saved config");
        }

        private void chk_mirrored_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mirrored.Checked)
                this.set_mirrored = 1;
            else
                this.set_mirrored = 0;
        }

        private void bt_c1plus_Click(object sender, EventArgs e)
        {
            if (trackBar_c1.Value < trackBar_c1.Maximum)
                trackBar_c1.Value++;
            trackBar_c1_Scroll(null, null);
        }

        private void bt_c1minus_Click(object sender, EventArgs e)
        {
            if (trackBar_c1.Value > trackBar_c1.Minimum)
                trackBar_c1.Value--;
            trackBar_c1_Scroll(null, null);
        }

        private void bt_c0plus_Click(object sender, EventArgs e)
        {
            trackBar_c0.Value++;
            trackBar_c0_Scroll(null, null);
        }

        private void bt_c0minus_Click(object sender, EventArgs e)
        {
            trackBar_c0.Value--;
            trackBar_c0_Scroll(null, null);
        }

        private void bt_gainplus_Click(object sender, EventArgs e)
        {
            if (trackBar_gain.Value < trackBar_gain.Maximum)
                trackBar_gain.Value++;
            trackBar_gain_Scroll(null, null);
        }

        private void bt_gainminus_Click(object sender, EventArgs e)
        {
            if (trackBar_gain.Value > trackBar_gain.Minimum)
                trackBar_gain.Value--;
            trackBar_gain_Scroll(null, null);
        }

        private void bt_offsetplus_Click(object sender, EventArgs e)
        {
            trackBar_offset.Value++;
            trackBar_offset_Scroll(null, null);
        }

        private void bt_offsetminus_Click(object sender, EventArgs e)
        {
            trackBar_offset.Value--;
            trackBar_offset_Scroll(null, null);
        }

        private void bt_vrefplus_Click(object sender, EventArgs e)
        {
            trackBar_vref.Value++;
            trackBar_vref_Scroll(null, null);
        }

        private void bt_vrefminus_Click(object sender, EventArgs e)
        {
            trackBar_vref.Value--;
            trackBar_vref_Scroll(null, null);
        }

        private void bt_setimage_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                PATH_OF_IMAGES = folderBrowserDialog1.SelectedPath;
                log.AppendText("New Imagepath: " + PATH_OF_IMAGES);
            }
        }

        private void number_image_ValueChanged(object sender, EventArgs e)
        {
            if (nb_image != null && (get == null || !get.isRunning()))
            {
                this.currentImage = number_image.Value;
                log.AppendText("Changed current image to: " + number_image.Value + "\r\n");
            }
        }

        private void number_folder_ValueChanged(object sender, EventArgs e)
        {
            if (nb_folder != null && (get == null || !get.isRunning()))
            {
                this.currentFolder = number_folder.Value;
                log.AppendText("Changed current folder to: " + nb_folder.Value + "\r\n");
            }
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

            // Scale the image by factor 2!
            for (int row = 0; row < 112; row++) // 112 rows
                for (int scaler_row = 0; scaler_row < 2; scaler_row++) // 4 times
                    for (int column = 0; column < 128; column++) // 128 pixels in a row
                    {
                        tempbyte = Convert.ToByte(data[(row * 128) + column]);
                        for (int scaler_column = 0; scaler_column < 6; scaler_column++) // 12 Times (2columm * 3RGB)
                            rgbValues[((row * 2 + scaler_row) * 256 * 3) + (column * 6) + scaler_column] = tempbyte;
                    }
            Marshal.Copy(rgbValues, 0, ptr, numBytes); // Copy the RGB values back to the bitmap

            bitmap_live_parent.UnlockBits(bmpData); // Unlock the bits.
            e.Graphics.DrawImage(bitmap_live_parent, 10, 10); // Left top

            nb_folder.Value = currentFolder;
            nb_image.Value = currentImage;
        }
        private void Form_Clicked(object sender, EventArgs e)
        {
            button_newview_Click(null, null);
        }

        public void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                bt_gainplus_Click(null, null);
            else if (e.KeyCode == Keys.Down)
                bt_gainminus_Click(null, null);
            else if (e.KeyCode == Keys.Right)
                bt_c1plus_Click(null, null);
            else if (e.KeyCode == Keys.Left)
                bt_c1minus_Click(null, null);
            else if (e.KeyCode == Keys.Space && !bt_start.Enabled)
                button_stop_Click(null, null);
            else if (e.KeyCode == Keys.Space && bt_start.Enabled)
                bt_start_Click(null, null);
            else if (e.KeyCode == Keys.Enter && view == null)
                button_newview_Click(null, null);
            else if (e.KeyCode == Keys.Escape && view != null || e.KeyCode == Keys.Enter && view != null)
                view.Close();
            else if (e.KeyCode == Keys.Escape && view == null)
                this.Close();
            else if (e.KeyCode == Keys.Tab)
            {
                number_folder.Value++;
                number_folder_ValueChanged(null, null);
                number_image.Value = 0;
                number_image_ValueChanged(null, null);
            }

            e.Handled = true;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            return false;
        }
    }
}