using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GameboyCameraClient
{
    public class Configuration
    {
        Form1 parent;
        public String PATH_OF_EXE, PATH_OF_CONFIG, PATH_OF_IMAGES;
        public FileStream file_config;

        public Configuration(Form1 parent)
        {
            this.parent = parent;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            PATH_OF_EXE = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            PATH_OF_CONFIG = PATH_OF_EXE + "\\config.xml";

            if (File.Exists(PATH_OF_CONFIG)) // Config already exists, read it
            {
                parent.log.AppendText("Found Config: " + PATH_OF_CONFIG + "\r\n");
                XmlReader reader = XmlReader.Create(PATH_OF_CONFIG);

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element
                    && reader.Name == "GameboySettings")
                    {
                        while (reader.NodeType != XmlNodeType.EndElement)
                        {
                            reader.Read();
                            if (reader.Name == "Gain")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_gain = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "Vh")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_vh = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "N")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_n = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "C1")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_c1 = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "C0")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_c0 = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "P")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_p = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "M")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_m = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "X")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_x = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "Vref")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_vref = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "I")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_i = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "EDGE")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_edge = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "OFFSET")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                    {
                                        // parent.tb_offset.Value = Byte.Parse(reader.Value);
                                        // parent.trackBar_offset_Scroll(null, null); 
                                        // TODO: Offset wird noch nicht geladen
                                    }
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "Z")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_z = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "Mode")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_mode = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "Mirrored")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.set_mirrored = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "Baud")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.baud = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "Imagepath")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                    {
                                        parent.PATH_OF_IMAGES = reader.Value;
                                        parent.log.AppendText("Image path: " + parent.PATH_OF_IMAGES + "\r\n");
                                    }
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "CurrentFolder")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.currentFolder = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                            else if (reader.Name == "CurrentImage")
                            {
                                while (reader.NodeType != XmlNodeType.EndElement)
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.Text)
                                        parent.currentImage = Int32.Parse(reader.Value);
                                }
                                reader.Read();
                            }
                        }
                    }
                }
            }
            else // Create new config with default values
            {
                parent.log.AppendText("Creating Config:" + PATH_OF_CONFIG + "\r\n");
                save_config();
            }
        }
        public void save_config()
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                XmlWriter writer = XmlWriter.Create(PATH_OF_CONFIG, settings);
                writer.WriteStartDocument();
                writer.WriteComment("This file is generated by the GameboyCamera Client software");

                writer.WriteStartElement("GameboySettings");
                writer.WriteElementString("Gain", parent.set_gain + "");
                writer.WriteElementString("Vh", parent.set_vh + "");
                writer.WriteElementString("N", parent.set_n + "");
                writer.WriteElementString("C1", parent.set_c1 + "");
                writer.WriteElementString("C0", parent.set_c0 + "");
                writer.WriteElementString("P", parent.set_p + "");
                writer.WriteElementString("M", parent.set_m + "");
                writer.WriteElementString("X", parent.set_x + "");
                writer.WriteElementString("Vref", parent.set_vref + "");
                writer.WriteElementString("I", parent.set_i + "");
                writer.WriteElementString("EDGE", parent.set_edge + "");
                writer.WriteElementString("OFFSET", parent.tb_offset.Value + ""); // Workaround: Save value of the knob
                writer.WriteElementString("Z", parent.set_z + "");

                writer.WriteElementString("Mode", parent.set_mode + "");
                writer.WriteElementString("Mirrored", parent.set_mirrored + "");
                writer.WriteElementString("Baud", parent.baud + "");
                // TODO: Comport?
                if (parent.PATH_OF_IMAGES == null)
                    parent.PATH_OF_IMAGES = PATH_OF_EXE + "\\Images";
                writer.WriteElementString("Imagepath", parent.PATH_OF_IMAGES);
                writer.WriteElementString("CurrentFolder", parent.currentFolder + "");
                writer.WriteElementString("CurrentImage", parent.currentImage + "");
                writer.WriteEndElement();

                writer.WriteEndDocument();

                writer.Flush();
                writer.Close();
            }
            catch (IOException ex)
            {
                parent.log.AppendText("Error saving: " + ex.ToString());
            }
        }
    }
}