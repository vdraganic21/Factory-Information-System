using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Presentation_Layer_Improved
{
    public static class FontSizeManager
    {
        public static void SetFontSize(double multiplier) 
        {
            double sizeDisplayText = 60 * multiplier;
            double sizeMainText = 32 * multiplier;
            double sizeTitleText = 24 * multiplier;
            double sizeSubtitle = 18 * multiplier;
            double sizeBodyText = 16 * multiplier;
            double sizeDetailText = 14 * multiplier;
            double sizeSmallestText = 12 * multiplier;

            Application.Current.Resources["sizeDisplayText"] = sizeDisplayText;
            Application.Current.Resources["sizeMainText"] = sizeMainText;
            Application.Current.Resources["sizeTitleText"] = sizeTitleText;
            Application.Current.Resources["sizeSubtitle"] = sizeSubtitle;
            Application.Current.Resources["sizeBodyText"] = sizeBodyText;
            Application.Current.Resources["sizeDetailText"] = sizeDetailText;
            Application.Current.Resources["sizeSmallestText"] = sizeSmallestText;
        }
    }
}
