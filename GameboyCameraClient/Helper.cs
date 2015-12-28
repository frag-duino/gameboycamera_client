using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameboyCameraClient
{
    class Helper
    {
        public static double[] VALUERANGE_GAIN = { 14.0, 15.5, 17.0, 18.5, 20.0, 21.5, 23.0, 24.5, 26.0, 29.0, 32.0, 35.0, 38.0, 41.0, 45.5, 51.5,
            20.0, 21.5, 23.0, 24.5, 26.0, 27.5, 29.0, 30.5, 32.0, 35.0, 38.0, 41.0, 44.0, 47.0, 51.5, 57.5 };
        public static double[] VALUERANGE_VREF = { 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5 };
        public static int[] VALUERANGE_EDGERATIO = { 50, 75, 100, 125, 200, 300, 400, 500 };
        public static String[] VALUERANGE_VHMODE = { "No edge operation", "Horizontal edge mode", "Vertical edge mode", "2-D edge mode" };
        public static String[] VALUERANGE_CALIBRATION = { "No calibration", "Calibration for positive signal", "Calibration for negative signal" };

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
