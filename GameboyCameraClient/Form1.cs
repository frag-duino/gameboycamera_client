using System;
using System.Drawing;
using System.IO.Ports;
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
        public int set_c1 = 23;
        public int set_c0 = 27;
        public int set_p = 1;
        public int set_m = 0;
        public int set_x = 1;
        public int set_vref = 3;
        public int set_i = 0;
        public int set_edge = 0;
        public byte set_offset = 0;
        public int set_z = 2;

        // Serial settings
        public String comport = "COM3";
        public int baud = 9600;

        // UI:
        public Bitmap bitmap;
        public Graphics graph;
        public TextBox log;
        public Button bt_start, bt_stop;

        // Threads
        GetThread get;
        Thread get_thread;

        public Form1()
        {
            InitializeComponent();

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

            foreach (String s in SerialPort.GetPortNames())
                comboBox_comport.Items.Add(s);
            if (comboBox_comport.Items.Count == 0)
                textBox1.AppendText("Error: No COM-Port available");
            else {
                comboBox_comport.SelectedIndex = 0;
                comport = comboBox_comport.Items[0].ToString();
                if (comboBox_comport.Items.Count == 1)
                    comboBox_comport.Enabled = false;
            }

            comboBox_baud.Items.Add(9600);
            comboBox_baud.Items.Add(115200);
            comboBox_baud.Items.Add(250000);
            comboBox_baud.SelectedIndex = 0;
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
            comboBox_vhmode.SelectedIndex = 0;
            comboBox_vhmode_SelectedIndexChanged(null, null);

            comboBox_edge_enhancement_mode.Items.Add(Helper.VALUERANGE_EDGE_ENHANCEMENT_MODE[0]);
            comboBox_edge_enhancement_mode.Items.Add(Helper.VALUERANGE_EDGE_ENHANCEMENT_MODE[1]);
            comboBox_edge_enhancement_mode.SelectedIndex = 0;
            comboBox_edge_enhancement_mode_SelectedIndexChanged(null, null);

            checkBox_inverted_CheckedChanged(null, null);
            checkBox_n_CheckedChanged(null, null);

            // Create image:
            bitmap = new Bitmap(128, 128);
            graph = CreateGraphics();
            graph.DrawImage(bitmap, 10, 10);
            log = textBox1;
            bt_start = button_start;
            bt_stop = button_stop;
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comport = (String)comboBox_comport.Items[comboBox_comport.SelectedIndex];
        }

        private void comboBox_baud_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.baud = (int) comboBox_baud.Items[comboBox_baud.SelectedIndex];
            }
            catch (Exception ex) { textBox1.AppendText("Error Parsing Baud-Rate:\r\n" + ex + "\r\n\r\n"); }
        }

        private void trackBar_gain_Scroll(object sender, EventArgs e)
        {
            set_gain = trackBar_gain.Value;
            label_gain_value.Text = set_gain + " bel / " + Helper.getBinaryRepresentation(set_gain, 5);
        }

        private void trackBar_vref_Scroll(object sender, EventArgs e)
        {
            set_vref = trackBar_vref.Value;
            label_vref_value.Text = Helper.VALUERANGE_VREF[set_vref].ToString() + "V / " + Helper.getBinaryRepresentation(set_vref, 3);
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
        }

        private void trackBar_offset_Scroll(object sender, EventArgs e)
        {
            byte temp2 = (byte) trackBar_offset.Value;
            if (trackBar_offset.Value >= 0)
            {
                temp2 = (byte) (temp2 + ((byte)32));
                label_offset_value.Text = "+" + trackBar_offset.Value * 32 + " mV / " + Helper.getBinaryRepresentation(temp2, 6);
            }
            else if (trackBar_offset.Value < 0)
            {
                temp2 = (byte)((32 - temp2)-32);
                label_offset_value.Text = trackBar_offset.Value * 32 + " mV / " + Helper.getBinaryRepresentation(temp2, 6);
            }
            set_offset = temp2;
        }

        private void checkBox_inverted_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_inverted.Checked)
                set_i = 1;
            else
                set_i = 0;
        }

        private void checkBox_n_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_n.Checked)
                set_n = 1;
            else
                set_n = 0;
        }

        private void checkBox_p_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p.Checked)
                set_p = 1;
            else
                set_p = 0;
        }

        private void checkBox_m_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_m.Checked)
                set_m = 1;
            else
                set_m = 0;
        }

        private void checkBox_x_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_x.Checked)
                set_x = 1;
            else
                set_x = 0;
        }

        private void trackBar_edge_Scroll(object sender, EventArgs e)
        {
            set_edge = trackBar_edge.Value & 7; // & 0111
            if (comboBox_edge_enhancement_mode.SelectedIndex == 1)
                set_edge = set_edge | 8;

            label_edge_value.Text = Helper.VALUERANGE_EDGERATIO[trackBar_edge.Value] + "% / " + Helper.getBinaryRepresentation(set_edge, 4);
        }

        private void comboBox_vhmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_vh = comboBox_vhmode.SelectedIndex;
            label_vhmode_value.Text = set_vh + " / " + Helper.getBinaryRepresentation(set_vh, 2);
        }

        private void comboBox_edge_enhancement_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackBar_edge_Scroll(null, null);
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            get.stopThread();
        }

        private void trackBar_c0_Scroll(object sender, EventArgs e)
        {
            set_c0 = trackBar_c0.Value;
            label_c0_value.Text = set_c0 + " / " + Helper.getBinaryRepresentation(set_c0, 8);
        }
    }
}
