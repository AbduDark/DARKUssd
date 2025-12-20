using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace USSDARK.Converters
{
    public class OperatorToGlowColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var operatorName = value?.ToString()?.ToLowerInvariant() ?? "";
            
            if (operatorName.Contains("vodafone") || operatorName.Contains("فودافون"))
                return Color.FromRgb(230, 0, 0);
            if (operatorName.Contains("orange") || operatorName.Contains("اورنج") || operatorName.Contains("موبينيل"))
                return Color.FromRgb(255, 121, 0);
            if (operatorName.Contains("etisalat") || operatorName.Contains("اتصالات"))
                return Color.FromRgb(128, 184, 38);
            if (operatorName.Contains("we") || operatorName.Contains("وي"))
                return Color.FromRgb(128, 0, 128);
            
            return Color.FromRgb(88, 166, 255);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
