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

        public Boolean something_has_changed()
        {
            return parent.haschanged_gain || parent.haschanged_vh || parent.haschanged_n || parent.haschanged_c1 ||
            parent.haschanged_c0 || parent.haschanged_p || parent.haschanged_m || parent.haschanged_x || parent.haschanged_vref ||
            parent.haschanged_i || parent.haschanged_edge || parent.haschanged_offset || parent.haschanged_z || 
            parent.haschanged_colordepth || parent.haschanged_resolution || parent.haschanged_mode;
        }

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

                if (parent.update_config || something_has_changed())
                {
                    // Send the current config to the device
                    parent.update_config = false;
                    logOutput(">Received ready. Sending config");
                    temp = 0;

                    if (parent.haschanged_gain)
                    {
                        outBuffer[temp] = (byte)Helper.TYPE_GAIN;
                        outBuffer[temp + 1] = (byte)parent.set_gain;
                        temp += 2;
                    }
                    if (parent.haschanged_vh)
                    {
                        outBuffer[temp] = (byte)Helper.TYPE_VH;
                        outBuffer[temp + 1] = (byte)parent.set_vh;
                        temp += 2;
                    }
                    if (parent.haschanged_n)
                    {
                        outBuffer[temp] = (byte)Helper.TYPE_N;
                        outBuffer[temp + 1] = (byte)parent.set_n;
                        temp += 2;
                    }
                    if (parent.haschanged_c1)
                    {
                        outBuffer[temp] = (byte)Helper.TYPE_C1;
                        outBuffer[temp + 1] = (byte)parent.set_c1;
                        temp += 2;
                    }
                    if (parent.haschanged_c0)
                    {
                        outBuffer[temp] = (byte)Helper.TYPE_C0;
                        outBuffer[temp + 1] = (byte)parent.set_c0;
                        temp += 2;
                    }
                    if (parent.haschanged_p)
                    {
                        outBuffer[temp] = (byte)Helper.TYPE_P;
                        outBuffer[temp + 1] = (byte)parent.set_p;
                        temp += 2;
                    }
                    if (parent.haschanged_m)
                    {
                        outBuffer[temp] = (byte)Helper.TYPE_M;
                        outBuffer[temp + 1] = (byte)parent.set_m;
                        temp += 2;
                    }
                    if (parent.haschanged_x)
                    {
                        outBuffer[temp] = (byte)Helper.TYPE_X;
                        outBuffer[temp + 1] = (byte)parent.set_x;
                        temp += 2;
                    }
                    if (parent.haschanged_vref)
                    {
                        outBuffer[temp] = (byte)Helper.TYPE_VREF;
                        outBuffer[temp + 1] = (byte)parent.set_vref;
                        temp += 2;
                    }
                    if (parent.haschanged_i)
                    {
                        outBuffer[temp] = (byte)Helper.TYPE_I;
                        outBuffer[temp + 1] = (byte)parent.set_i;
                        temp += 2;
                    }
                    if (parent.haschanged_edge)
                    {
                        outBuffer[temp] = (byte)Helper.TYPE_EDGE;
                        outBuffer[temp + 1] = (byte)parent.set_edge;
                        temp += 2;
                    }
                    if (parent.haschanged_offset)
                    {
                        outBuffer[temp] = (byte)Helper.TYPE_OFFSET;
                        outBuffer[temp + 1] = (byte)parent.set_offset;
                        temp += 2;
                    }
                    if (parent.haschanged_z)
                    {
                        outBuffer[temp] = (byte)Helper.TYPE_Z;
                        outBuffer[temp + 1] = (byte)parent.set_z;
                        temp += 2;
                    }
                    if (parent.haschanged_resolution)
                    {
                        outBuffer[temp] = (byte)Helper.COMMAND_RESOLUTION;
                        outBuffer[temp + 1] = (byte)parent.set_resolution;
                        temp += 2;
                    }
                    if (parent.haschanged_colordepth)
                    {
                        outBuffer[temp] = (byte)Helper.COMMAND_COLORDEPTH;
                        outBuffer[temp + 1] = (byte)parent.set_colordepth;
                        temp += 2;
                    }
                    if (parent.haschanged_mode)
                    {
                        outBuffer[temp] = (byte)Helper.COMMAND_MODE;
                        outBuffer[temp + 1] = (byte)parent.set_mode;
                        temp += 2;
                    }

                    outBuffer[temp] = (byte)'\n'; // Dec: 10
                    
                    // Remove /n (Decimal 10) from the stream :( stupid, but works
                    for (int i = 0; i < temp; i++)
                        if (outBuffer[i] == 10)
                        {
                            outBuffer[i]++;
                            logOutput("Removed \\n (dec 10) from the output");
                        }
                    mySerialport.Write(outBuffer, 0, temp + 1);

                    parent.hasChangedALL(false);

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
