using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;

using System.Windows.Forms;

namespace GameboyCameraClient
{
    class GetThread 
    {

        // Variables
        Form1 parent;
        int dataIn, temp;
        int row;
        int column;
        Boolean readyToReceive = false;
        String input = "";
        Boolean running = true;
        SerialPort mySerialport;

        public GetThread(Form1 parent)
        {
            this.parent = parent;
        }

        public void stopThread()
        {
            logOutput("Trying to stop");
            running = false;
        }

        void logOutput(String value)
        {
            parent.log.Invoke((MethodInvoker)delegate ()
            {
                parent.log.AppendText(value + "\r\n");
            });
        }

        public void getPhoto()
        {
            row = 0;
            column = 0;

            try
            {
                mySerialport = new SerialPort(parent.comport, parent.baud);
                mySerialport.ReadTimeout = 5000;
                mySerialport.Open();
                while (running)
                {
                    if (!readyToReceive)
                    {
                        input = mySerialport.ReadLine();
                        if (input.Contains("!READY!"))
                        {
                            readyToReceive = true;
                            if (parent.update_config)
                            {
                                parent.update_config = false;
                                logOutput(">Received ready. Sending config");

                                // Set the values:
                                mySerialport.WriteLine("" + Helper.TYPE_GAIN + (char)parent.set_gain);
                                mySerialport.WriteLine("" + Helper.TYPE_VH + (char)parent.set_vh);
                                mySerialport.WriteLine("" + Helper.TYPE_N + (char)parent.set_n);
                                mySerialport.WriteLine("" + Helper.TYPE_C1 + (char)parent.set_c1);
                                mySerialport.WriteLine("" + Helper.TYPE_C0 + (char)parent.set_c0);
                                mySerialport.WriteLine("" + Helper.TYPE_P + (char)parent.set_p);
                                mySerialport.WriteLine("" + Helper.TYPE_M + (char)parent.set_m);
                                mySerialport.WriteLine("" + Helper.TYPE_X + (char)parent.set_x);
                                mySerialport.WriteLine("" + Helper.TYPE_VREF + (char)parent.set_vref);
                                mySerialport.WriteLine("" + Helper.TYPE_I + (char)parent.set_i);
                                mySerialport.WriteLine("" + Helper.TYPE_EDGE + (char)parent.set_edge);
                                mySerialport.WriteLine("" + Helper.TYPE_OUT + (char)parent.set_offset);
                                mySerialport.WriteLine("" + Helper.TYPE_Z + (char)parent.set_z);

                                mySerialport.WriteLine("" + Helper.COMMAND_COLORDEPTH + (char)parent.set_colordepth);
                                mySerialport.WriteLine("" + Helper.COMMAND_SETCONFIG);
                                
                                logOutput(">finished sending config");
                            }

                            mySerialport.WriteLine("" + Helper.COMMAND_TAKEPHOTO);
                            
                            while (running)
                            {
                                input = mySerialport.ReadLine();
                                logOutput("<" + input.Replace("\n", "\r\n"));
                                if (input.Contains("!IMAGE!"))
                                    break;
                            }
                        }
                        else if (input.Contains("END!"))
                        {
                            logOutput("Found the end!");
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

                            temp *= 64; // because of 2 bit 0-3 -> 0-255

                            Color c = Color.FromArgb(temp, temp, temp);
                            parent.bitmap.SetPixel(column, row, c);

                            column++;

                            if (column == 128)
                            {
                                column = 0;
                                row++;
                            }

                            if (row == 123) // TODO: 5 pixel fehlen!
                            {
                                readyToReceive = false;
                                parent.graph.DrawImage(parent.bitmap, 10, 10);
                                break;
                            }

                        }
                        parent.graph.DrawImage(parent.bitmap, 10, 10);
                    }
                }
            }
            catch (IOException ex)
            { logOutput("Error:" + ex.ToString()); }
            catch (TimeoutException ex) { logOutput("Timeout."); }
            finally
            {
                mySerialport.Close();
                logOutput("Serial Port closed\r\n");
            }

            // Reenable the button
            parent.log.Invoke((MethodInvoker)delegate ()
            {
                parent.bt_start.Enabled = true;
                parent.bt_stop.Enabled = false;
            });
            logOutput("Thread Finished");

        }
    }
}
