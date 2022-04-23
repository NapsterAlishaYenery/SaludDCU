using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludDCU
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecundaryColor { get; set; }

        public static List<string> ColorList = new List<string>() 
        {
            "#F0F8FF",
            "#FAEBD7",
            "#8A2BE2",
            "#6495ED",
            "#FFF8DC",
            "#DC143C",
            "#008B8B",
            "#006400",
            "#FF8C00",
            "#2F4F4F",
            "#00CED1",
            "#FFD700",
            "#ADFF2F",
            "#F0FFF0",
            "#90EE90",
            "#20B2AA",
            "#191970",
            "#FF4500",
            "#2E8B57",
            "#FFFF00"
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //If Correction Factor is less than 0, darken color 
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If Correction Factoe is greater than 0, lighten colo
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue );
        }
    }
}
