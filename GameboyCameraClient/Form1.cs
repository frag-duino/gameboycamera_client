using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameboyCameraClient
{
    public partial class Form1 : Form
    {
        byte[] currentPixel = new byte[128 * 128 +100];
        String input = "";
        
        // Protocol
        const char TYPE_GAIN = 'G';
        const char TYPE_VH = 'H';
        const char TYPE_N = 'N';
        const char TYPE_C1 = '1';
        const char TYPE_C0 = '0';
        const char TYPE_P = 'P';
        const char TYPE_M = 'M';
        const char TYPE_X = 'X';
        const char TYPE_VREF = 'V';
        const char TYPE_I = 'I';
        const char TYPE_EDGE = 'E';
        const char TYPE_OUT = 'O';
        const char TYPE_Z = 'Z';

        const int MODE_8BIT = 8;
        const int MODE_2BIT = 2;
        const int MODE_TEST = 0;

        const char COMMAND_TAKEPHOTO = 'T';
        const char COMMAND_SETCONFIG = 'S';
        const char COMMAND_COLORDEPTH = 'D';

        // Variables
        Boolean readyToReceive = false;
        int set_gain = 0;
        int set_vh = 3;
        int set_n = 0;
        int set_c1 = 23;
        int set_c0 = 27;
        int set_p = 1;
        int set_m = 0;
        int set_x = 1;
        int set_vref = 3;
        int set_i = 0;
        int set_edge = 0;
        byte set_offset = 0;
        int set_z = 2;

        int dataIn, temp;
        int row;
        int column;
        String comport = "COM3";
        int baud = 9600;

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
        }

        private void bt_start_Click(object sender, EventArgs e)
        {

            Bitmap bitmap = new Bitmap("background.bmp");
            Graphics graph = CreateGraphics();
            row = 0;
            column = 0;
                        
            try {
                SerialPort mySerialport = new SerialPort(comport, baud);
                mySerialport.Open();
                while (true)
                {
                    if (!readyToReceive)
                    {
                        input = mySerialport.ReadLine();
                        if (input.Contains("ready"))
                        {
                            readyToReceive = true;
                            textBox1.AppendText(">Received ready. Sending config\r\n");

                            // Set the values:
                            mySerialport.WriteLine("" + TYPE_GAIN + (char)set_gain);
                            mySerialport.WriteLine("" + TYPE_VH + (char)set_vh);
                            mySerialport.WriteLine("" + TYPE_N + (char)set_n);
                            mySerialport.WriteLine("" + TYPE_C1 + (char)set_c1);
                            mySerialport.WriteLine("" + TYPE_C0 + (char)set_c0);
                            mySerialport.WriteLine("" + TYPE_P + (char)set_p);
                            mySerialport.WriteLine("" + TYPE_M + (char)set_m);
                            mySerialport.WriteLine("" + TYPE_X + (char)set_x);
                            mySerialport.WriteLine("" + TYPE_VREF + (char)set_vref);
                            mySerialport.WriteLine("" + TYPE_I + (char)set_i);
                            mySerialport.WriteLine("" + TYPE_EDGE + (char)set_edge);
                            mySerialport.WriteLine("" + TYPE_OUT + (char)set_offset);
                            mySerialport.WriteLine("" + TYPE_Z + (char)set_z);

                            mySerialport.WriteLine("" + COMMAND_COLORDEPTH + (char)MODE_2BIT);
                            mySerialport.WriteLine("" + COMMAND_SETCONFIG);
                            mySerialport.WriteLine("" + COMMAND_TAKEPHOTO);

                            textBox1.AppendText(">finished sending config\r\n");

                            while (true)
                            {
                                input = mySerialport.ReadLine();
                                textBox1.AppendText("<" + input.Replace("\n", "\r\n") + "\r\n");
                                if (input.Contains("IMAGE:"))
                                    break;
                            }
                        }
                        else if (input.Contains("END!"))
                        {
                            textBox1.AppendText("Found the end!\r\n");
                            break;
                        }
                    }

                    if (readyToReceive)
                    {
                        dataIn = mySerialport.ReadByte();

                        for (int pixel = 0; pixel < 4; pixel++)
                        {

                            temp = dataIn;
                            temp = temp << (pixel * 2);
                            temp = temp & 0xFF;
                            temp = temp >> 6;

                            // println(dataIn);
                            temp *= 64;

                            Color c = Color.FromArgb(temp, temp, temp);
                            bitmap.SetPixel(column, row, c);

                            column++;

                            if (column == 128)
                            {
                                column = 0;
                                row++;
                            }


                            if (row == 123) // TODO: 5 pixel fehlen!
                            {
                                readyToReceive = false;
                                graph.DrawImage(bitmap, 10, 10);
                                break;
                            }

                        }
                        graph.DrawImage(bitmap, 10, 10);
                    }
                }
                mySerialport.Close();
                textBox1.AppendText("Serial Port closed\r\n");
            }
            catch (IOException ex)
            { textBox1.AppendText(ex.ToString()); }

                                 
            textBox1.AppendText("Finished");
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

        private void trackBar_c0_Scroll(object sender, EventArgs e)
        {
            set_c0 = trackBar_c0.Value;
            label_c0_value.Text = set_c0 + " / " + Helper.getBinaryRepresentation(set_c0, 8);
        }
    }
}
