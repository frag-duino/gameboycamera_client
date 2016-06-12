using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GameboyCameraClient
{
    class GetThread
    {

        // Constants
        int MAXIMUM_IMAGES_PER_FOLDER = 100;

        // Variables
        public Bitmap bitmap_for_saving;
        byte tempbyte;
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
        SoundPlayer shutterSound = new SoundPlayer(GameboyCameraClient.Properties.Resources.shutter);

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
            if (parent.comport.Equals(""))
            {
                logOutput("No COM-Port selected");
                reenableButtons();
                return;
            }

            // Initialize Serial communication:
            mySerialport = new SerialPort(parent.comport, parent.baud);
            mySerialport.Parity = Parity.None;
            mySerialport.StopBits = StopBits.One;

            inBuffer = new byte[mySerialport.ReadBufferSize];
            mySerialport.ReadTimeout = 5000; // Set the timeout
            try
            {
                mySerialport.Open();
            }
            catch (IOException e)
            {
                logOutput("IO-Error. COM-Port in use?");
                Console.WriteLine(e.ToString());
                running = false;
            }

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
                        logOutput("Timeout sending config ");
                        Console.WriteLine(e.ToString());
                        continue;
                    }
                }

                try
                {
                    receivedlength = mySerialport.Read(inBuffer, 0, inBuffer.Length); // Receive bytes
                }
                catch (TimeoutException e)
                {
                    logOutput("Timeout");
                    Console.WriteLine(e.ToString());
                    continue;
                }
                catch (IOException e)
                {
                    logOutput("No COM-Port selected");
                    Console.WriteLine(e.ToString());
                    reenableButtons();
                    return;
                }

                for (int i = 0; i < receivedlength; i++)
                {
                    if (inBuffer[i] == Helper.BYTE_PHOTO_BEGIN)  // Check if the begin-byte arrived:
                    {
                        // logOutput("Found the beginning");
                        is_receiving_photo = true;
                        row = 0;
                        column = 0;
                        continue;
                    }
                    else if (inBuffer[i] == Helper.BYTE_PHOTO_END_SHOW || inBuffer[i] == Helper.BYTE_PHOTO_END_SAVE) // Check if the last byte arrived:
                    {
                        // logOutput("Found the ending");

                        // Mirror image vertically
                        if (parent.set_mirrored == 1)
                            for (int row = 0; row < 112; row++)
                            {
                                for (int column = 0; column < 128 / 2; column++)
                                {
                                    temp = parent.data[row * 128 + column];
                                    parent.data[row * 128 + column] = parent.data[row * 128 + 127 - column];
                                    parent.data[row * 128 + 127 - column] = temp;
                                }
                            }

                        if (inBuffer[i] == Helper.BYTE_PHOTO_END_SAVE)
                            saveBitmap();

                        is_receiving_photo = false;
                        parent.Invalidate();
                        if (parent.view != null)
                            parent.view.Invalidate();
                        continue;
                    }
                    

                    if (is_receiving_photo)
                        for (int pixel = 0; pixel < 4; pixel++)
                        {
                            temp = inBuffer[i];
                            temp = temp << (pixel * 2);
                            temp = temp & 0xFF;
                            temp = temp >> 6;

                            temp *= 85; // because of 2 bit 0-3 -> 0-255

                            // New bitmap print:
                            parent.data[row * 128 + column] = temp;

                            column++;

                            if (column == 128)
                            {
                                column = 0;
                                row++;
                            }

                            if (row == 112)
                            {
                                is_receiving_photo = false;
                                continue;
                            }
                        }
                }
            }
            
            try
            {
                mySerialport.Close();
                logOutput("Serial Port closed\r\n");
                reenableButtons();
                logOutput("Thread Finished");
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
        }

        public void reenableButtons()
        {
            // Reenable the button
            parent.log.Invoke((MethodInvoker)delegate ()
            {
                parent.bt_start.Enabled = true;
                parent.bt_stop.Enabled = false;
                parent.nb_folder.Enabled = true;
                parent.nb_image.Enabled = true;
            });
        }

        public Boolean isRunning()
        {
            return running;
        }
        public void saveBitmap()
        {
            if (parent.set_sound == 1)
                shutterSound.Play();

            // Create a bitmap for saving:
            Rectangle rect = new Rectangle(0, 0, 128, 112);
            bitmap_for_saving = new Bitmap(128, 112, PixelFormat.Format24bppRgb);
            BitmapData bmpData =
            bitmap_for_saving.LockBits(rect, ImageLockMode.ReadWrite,
                         PixelFormat.Format24bppRgb);
            IntPtr ptr = bmpData.Scan0; // Get the address of the first line.
            int numBytes = bitmap_for_saving.Width * bitmap_for_saving.Height * 3; // RGB
            byte[] rgbValues = new byte[numBytes];
            for (int counter = 0; counter < parent.data.Length; counter++)
            {
                tempbyte = Convert.ToByte(parent.data[counter]);
                rgbValues[(counter * 3) + 0] = tempbyte;
                rgbValues[(counter * 3) + 1] = tempbyte;
                rgbValues[(counter * 3) + 2] = tempbyte;
            }
            Marshal.Copy(rgbValues, 0, ptr, numBytes); // Copy the RGB values back to the bitmap
            bitmap_for_saving.UnlockBits(bmpData); // Unlock the bits.

            if (parent.view != null)
            {
                // First shift the images to the right:
                for (int image = 2; image > 0; image--)
                {
                    parent.view.label_save[image] = parent.view.label_save[image - 1]; // Shift the label

                    for (int s = 0; s < 128 * 112; s++) // and the image
                        parent.view.data_save[image, s] = parent.view.data_save[image - 1, s];
                }

                // Save the new one
                parent.view.label_save[0] = parent.currentFolder + "-" + parent.currentImage;
                for (int s = 0; s < 128 * 112; s++)
                    parent.view.data_save[0, s] = parent.data[s];

                if (parent.view != null)
                    parent.view.Invalidate();
            }

            // Check the folders
            if (!System.IO.Directory.Exists(parent.PATH_OF_IMAGES))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(parent.PATH_OF_IMAGES);
                    logOutput("Path for images does not exist, creating it: " + parent.PATH_OF_IMAGES);
                }
                catch (IOException e)
                {
                    logOutput("ERROR: PATH FOR IMAGES DOES NOT EXIST: " + parent.PATH_OF_IMAGES);
                    Console.WriteLine(e.ToString());
                }
            }

            if (!System.IO.Directory.Exists(parent.PATH_OF_IMAGES + "\\" + parent.currentFolder))
            {
                logOutput("Image-Path for " + parent.currentFolder + " does not exist, creating it: ");
                System.IO.Directory.CreateDirectory(parent.PATH_OF_IMAGES + "\\" + parent.currentFolder);
            }

            parent.filename = "gb_" + parent.currentFolder + "_" + parent.currentImage + ".png";
            
            // Increment the counter:
            parent.currentImage++;
            if (parent.currentImage == MAXIMUM_IMAGES_PER_FOLDER)
            {
                parent.currentFolder++;
                parent.currentImage = 0;
                logOutput("Next folder: " + parent.currentFolder);
            }

            // Check if file already exists:
            if (System.IO.File.Exists(parent.PATH_OF_IMAGES + "\\" + parent.currentFolder + "\\" + parent.filename))
            {
                parent.errormessage = "Image not saved, file already exists: \r\n" + parent.filename;
                logOutput("\r\n\r\n\r" + parent.errormessage + "\r\n");
                return;
            }
            else
            {
                parent.errormessage = "";
                bitmap_for_saving.Save(parent.PATH_OF_IMAGES + "\\" + parent.currentFolder + "\\" + parent.filename, ImageFormat.Png);
            }
        }
    }
}
