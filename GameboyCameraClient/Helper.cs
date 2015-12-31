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

        public static int[] MODE_RESOLUTION = { 2, 8, 0, 1 };
        public static int MODE_2BIT = 2;
        public static int MODE_8BIT = 8;
        public static int MODE_TEST2BIT = 0;
        public static int MODE_TEST8BIT = 1;

        public static char COMMAND_TAKEPHOTO = 'T';
        public static char COMMAND_SETCONFIG = 'S';
        public static char COMMAND_COLORDEPTH = 'D';

        public static double[] VALUERANGE_GAIN = { 14.0, 15.5, 17.0, 18.5, 20.0, 21.5, 23.0, 24.5, 26.0, 29.0, 32.0, 35.0, 38.0, 41.0, 45.5, 51.5,
            20.0, 21.5, 23.0, 24.5, 26.0, 27.5, 29.0, 30.5, 32.0, 35.0, 38.0, 41.0, 44.0, 47.0, 51.5, 57.5 };
        public static double[] VALUERANGE_VREF = { 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5 };
        public static int[] VALUERANGE_EDGERATIO = { 50, 75, 100, 125, 200, 300, 400, 500 };
        public static String[] VALUERANGE_VHMODE = { "No edge operation", "Horizontal edge mode", "Vertical edge mode", "2-D edge mode" };
        public static String[] VALUERANGE_CALIBRATION = { "No calibration", "Calibration for positive signal", "Calibration for negative signal" };
        public static String[] VALUERANGE_EDGE_ENHANCEMENT_MODE = { "edge extraction mode", "edge enhancement mode" };
        public static String[] VALUERANGE_RESOLUTION = { "2 Bit (4 colors)", "8 Bit (255 colors)", "2 Bit Test Mode", "8 Bit Test Mode" };
        
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
