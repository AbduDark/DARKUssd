using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ModemPoolManager.Converters;

public class OperatorToBrushConverter : IValueConverter
{
    private static readonly Dictionary<string, SolidColorBrush> OperatorColors = new(StringComparer.OrdinalIgnoreCase)
    {
        { "Vodafone", new SolidColorBrush(Color.FromRgb(230, 0, 0)) },
        { "فودافون", new SolidColorBrush(Color.FromRgb(230, 0, 0)) },
        { "VF EG", new SolidColorBrush(Color.FromRgb(230, 0, 0)) },
        
        { "Orange", new SolidColorBrush(Color.FromRgb(255, 121, 0)) },
        { "اورنج", new SolidColorBrush(Color.FromRgb(255, 121, 0)) },
        { "Mobinil", new SolidColorBrush(Color.FromRgb(255, 121, 0)) },
        
        { "Etisalat", new SolidColorBrush(Color.FromRgb(128, 184, 38)) },
        { "اتصالات", new SolidColorBrush(Color.FromRgb(128, 184, 38)) },
        { "etisalat misr", new SolidColorBrush(Color.FromRgb(128, 184, 38)) },
        
        { "WE", new SolidColorBrush(Color.FromRgb(118, 45, 148)) },
        { "وي", new SolidColorBrush(Color.FromRgb(118, 45, 148)) },
        { "Telecom Egypt", new SolidColorBrush(Color.FromRgb(118, 45, 148)) },
        
        { "STC", new SolidColorBrush(Color.FromRgb(79, 40, 125)) },
        
        { "Mobily", new SolidColorBrush(Color.FromRgb(0, 163, 224)) },
        { "موبايلي", new SolidColorBrush(Color.FromRgb(0, 163, 224)) },
        
        { "Zain", new SolidColorBrush(Color.FromRgb(105, 190, 40)) },
        { "زين", new SolidColorBrush(Color.FromRgb(105, 190, 40)) },
        
        { "MTN", new SolidColorBrush(Color.FromRgb(255, 204, 0)) },
        
        { "Airtel", new SolidColorBrush(Color.FromRgb(237, 28, 36)) },
        
        { "Ooredoo", new SolidColorBrush(Color.FromRgb(234, 0, 41)) },
    };

    private static readonly SolidColorBrush DefaultBrush = new(Color.FromRgb(88, 166, 255));

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string operatorName && !string.IsNullOrEmpty(operatorName))
        {
            foreach (var kvp in OperatorColors)
            {
                if (operatorName.Contains(kvp.Key, StringComparison.OrdinalIgnoreCase))
                {
                    return kvp.Value;
                }
            }
        }
        return DefaultBrush;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
