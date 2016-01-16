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
            try
            {
                mySerialport = new SerialPort(parent.comport, parent.baud);
                inBuffer = new byte[mySerialport.ReadBufferSize];
                // mySerialport.ReadTimeout = 5000;
                mySerialport.Open();

                while (running)
                {
                    receivedlength = mySerialport.Read(inBuffer, 0, inBuffer.Length);
                    
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
            }
            catch (Exception e)
            {

            }
        }
    }
}
