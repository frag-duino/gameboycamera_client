using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameboyCameraClient
{
    class Helper
    {

        // Protocol
        public static char TYPE_GAIN = 'G';
        public static char TYPE_VH = 'H';
        public static char TYPE_N = 'N';
        public static char TYPE_C1 = '1';
        public static char TYPE_C0 = '0';
        public static char TYPE_P = 'P';
        public static char TYPE_M = 'M';
        public static char TYPE_X = 'X';
        public static char TYPE_VREF = 'V';
        public static char TYPE_I = 'I';
        public static char TYPE_EDGE = 'E';
        public static char TYPE_OUT = 'O';
        public static char TYPE_Z = 'Z';

        public static int COLORDEPTH_8BIT = 8;
        public static int COLORDEPTH_2BIT = 2;
        public static int RESOLUTION_128PX = 1;
        public static int RESOLUTION_32PX = 3;
        public static int MODE_REGULAR = 0;
        public static int MODE_TEST = 1;

        public static char COMMAND_TAKEPHOTO = 'T';
        public static char COMMAND_COLORDEPTH = 'D';
        public static char COMMAND_RESOLUTION = 'R';
        public static char COMMAND_MODE = 'F';

        public static Byte BYTE_PHOTO_BEGIN = 204; // 11001100
        public static Byte BYTE_PHOTO_END = 51; // 00110011

        public static double[] VALUERANGE_GAIN = { 14.0, 15.5, 17.0, 18.5, 20.0, 21.5, 23.0, 24.5, 26.0, 29.0, 32.0, 35.0, 38.0, 41.0, 45.5, 51.5,
            20.0, 21.5, 23.0, 24.5, 26.0, 27.5, 29.0, 30.5, 32.0, 35.0, 38.0, 41.0, 44.0, 47.0, 51.5, 57.5 };
        public static double[] VALUERANGE_VREF = { 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5 };
        public static int[] VALUERANGE_EDGERATIO = { 50, 75, 100, 125, 200, 300, 400, 500 };
        public static String[] VALUERANGE_VHMODE = { "No edge operation", "Horizontal edge mode", "Vertical edge mode", "2-D edge mode" };
        public static String[] VALUERANGE_CALIBRATION = { "No calibration", "Calibration for positive signal", "Calibration for negative signal" };
        public static String[] VALUERANGE_EDGE_ENHANCEMENT_MODE = { "edge extraction mode", "edge enhancement mode" };
        public static String[] VALUERANGE_RESOLUTION = { "2Bit (4 colors) 128x128px", "8Bit (255 colors) 32x32px", "8 Bit (255 colors) 128x128px" };
        
        static public String getBinaryRepresentation(int value, int amount_digits)
        {
            String output = "";
            output = Convert.ToString(value, 2);
            for (int fill = output.Length; fill < amount_digits; fill++)
                output = "0" + output;
            return "B" + output;
        }
    }
}
