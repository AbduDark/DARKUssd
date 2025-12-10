using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ModemPoolManager.Converters;

public class OtpVisibilityConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values.Length >= 2 && values[0] is bool isWithdrawn && values[1] is bool isExpired)
        {
            return !isWithdrawn && !isExpired;
        }
        return true;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
