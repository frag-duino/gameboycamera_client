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
        int temp = 0;
        int row = 0;
        int column = 0;
        Boolean is_receiving_photo = false;
        String input = "";
        Boolean running = true;
        SerialPort mySerialport;
        byte[] inBuffer;
        byte[] outBuffer = new byte[33];
        int receivedlength = 0;


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
            try
            {
                parent.log.Invoke((MethodInvoker)delegate ()
            {
                parent.log.AppendText(value + "\r\n");
            });
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec);
            }
        }

        public void getPhoto()
        {
            // Initialize Serial communication:
            mySerialport = new SerialPort(parent.comport, parent.baud);
            mySerialport.Parity = Parity.None;
            mySerialport.StopBits = StopBits.One;

            inBuffer = new byte[mySerialport.ReadBufferSize];
            mySerialport.ReadTimeout = 5000; // Set the timeout
            mySerialport.Open();

            while (running)
            {

                if (parent.update_config)
                {
                    // Send the current config to the device
                    parent.update_config = false;
                    logOutput(">Received ready. Sending config");
                    outBuffer[0] = (byte)Helper.TYPE_GAIN;
                    outBuffer[1] = (byte)parent.set_gain;
                    outBuffer[2] = (byte)Helper.TYPE_VH;
                    outBuffer[3] = (byte)parent.set_vh;
                    outBuffer[4] = (byte)Helper.TYPE_N;
                    outBuffer[5] = (byte)parent.set_n;
                    outBuffer[6] = (byte)Helper.TYPE_C1;
                    outBuffer[7] = (byte)parent.set_c1;
                    outBuffer[8] = (byte)Helper.TYPE_C0;
                    outBuffer[9] = (byte)parent.set_c0;
                    outBuffer[10] = (byte)Helper.TYPE_P;
                    outBuffer[11] = (byte)parent.set_p;
                    outBuffer[12] = (byte)Helper.TYPE_M;
                    outBuffer[13] = (byte)parent.set_m;
                    outBuffer[14] = (byte)Helper.TYPE_X;
                    outBuffer[15] = (byte)parent.set_x;
                    outBuffer[16] = (byte)Helper.TYPE_VREF;
                    outBuffer[17] = (byte)parent.set_vref;
                    outBuffer[18] = (byte)Helper.TYPE_I;
                    outBuffer[19] = (byte)parent.set_i;
                    outBuffer[20] = (byte)Helper.TYPE_EDGE;
                    outBuffer[21] = (byte)parent.set_edge;
                    outBuffer[22] = (byte)Helper.TYPE_OFFSET;
                    outBuffer[23] = (byte)parent.set_offset;
                    outBuffer[24] = (byte)Helper.TYPE_Z;
                    outBuffer[25] = (byte)parent.set_z;
                    outBuffer[26] = (byte)Helper.COMMAND_RESOLUTION;
                    outBuffer[27] = (byte)parent.set_resolution;
                    outBuffer[28] = (byte)Helper.COMMAND_COLORDEPTH;
                    outBuffer[29] = (byte)parent.set_colordepth;
                    outBuffer[30] = (byte)Helper.COMMAND_MODE;
                    outBuffer[31] = (byte)parent.set_mode;
                    outBuffer[32] = (byte)'\n'; // Dec: 10
                    mySerialport.Write(outBuffer, 0, 33);

                    // Remove /n (Decimal 10) from the stream :( stupid, but works
                    for (int i = 0; i < 32; i++)
                        if (outBuffer[i] == 10)
                        {
                            outBuffer[i]++;
                            logOutput("Removed \\n (dec 10) from the output");
                        }

                    logOutput(">finished sending config");
                    try
                    {
                        input = mySerialport.ReadLine();
                        logOutput("Answer:\"" + input + "\"");
                    }
                    catch (TimeoutException e)
                    {
                        logOutput("Timeout sending config");
                        continue;
                    }
                }

                try {
                    receivedlength = mySerialport.Read(inBuffer, 0, inBuffer.Length); // Receive bytes
                }
                catch(TimeoutException e)
                {
                    logOutput("Timeout");
                    continue;
                }

                for (int i = 0; i < receivedlength; i++)
                {
                    if (inBuffer[i] == Helper.BYTE_PHOTO_BEGIN)  // Check if the begin-byte arrived:
                    {
                        logOutput("Found the beginning");
                        is_receiving_photo = true;
                        row = 0;
                        column = 0;
                        continue;
                    }
                    else if (inBuffer[i] == Helper.BYTE_PHOTO_END) // Check if the last byte arrived:
                    {
                        logOutput("Found the ending");
                        is_receiving_photo = false;
                        continue;
                    }

                    if (!is_receiving_photo)
                    {
                        // ignore it
                    }
                    else if (parent.set_resolution == Helper.RESOLUTION_128PX && parent.set_colordepth == Helper.COLORDEPTH_2BIT) // 2Bit, 128x128
                    {
                        for (int pixel = 0; pixel < 4; pixel++)
                        {
                            temp = inBuffer[i];
                            temp = temp << (pixel * 2);
                            temp = temp & 0xFF;
                            temp = temp >> 6;

                            temp *= 85; // because of 2 bit 0-3 -> 0-255

                            Color c = Color.FromArgb(temp, temp, temp);
                            parent.bitmap.SetPixel(column, row, c);

                            column++;

                            if (column == 128)
                            {
                                column = 0;
                                row++;
                            }

                            if (row == 128)
                            {
                                logOutput("Last byte reached (2Bit, 128x128)");
                                is_receiving_photo = false;
                                continue;
                            }
                        }
                    }
                    else if (parent.set_resolution == Helper.RESOLUTION_32PX && parent.set_colordepth == Helper.COLORDEPTH_8BIT) // 8Bit, 32x32
                    {
                        temp = inBuffer[i];
                        Color c = Color.FromArgb(temp, temp, temp);

                        parent.bitmap.SetPixel(column, row, c);

                        column++;

                        if (column == 32)
                        {
                            column = 0;
                            row++;
                        }

                        if (row == 32)
                        {
                            logOutput("Last byte reached (8Bit, 32x32)");
                            is_receiving_photo = false;
                            continue;
                        }
                        // TODO: Implement scaling here!
                    }
                    else if (parent.set_resolution == Helper.RESOLUTION_128PX && parent.set_colordepth == Helper.COLORDEPTH_8BIT) // 8Bit, 128x128
                    {
                        temp = inBuffer[i];
                        Color c = Color.FromArgb(temp, temp, temp);
                        parent.bitmap.SetPixel(column, row, c);

                        column++;

                        if (column == 128)
                        {
                            column = 0;
                            row++;
                        }

                        if (row == 128)
                        {
                            logOutput("Last byte reached (8Bit, 128x128)");
                            is_receiving_photo = false;
                            continue;
                        }
                    }
                }

                // Draw the current bitmap
                try { parent.graph.DrawImage(parent.bitmap, 10, 10); }
                catch (Exception ec) { Console.WriteLine("Already finished: " + ec.ToString()); }
            }

            try
            {
                mySerialport.Close();
                logOutput("Serial Port closed\r\n");

                // Reenable the button
                parent.log.Invoke((MethodInvoker)delegate ()
                {
                    parent.bt_start.Enabled = true;
                    parent.bt_stop.Enabled = false;
                });
                logOutput("Thread Finished");
            }
            catch (Exception e)
            {

            }
        }
    }
}
