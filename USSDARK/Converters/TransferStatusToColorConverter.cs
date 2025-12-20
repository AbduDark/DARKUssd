using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace USSDARK.Converters;

public class TransferStatusToColorConverter : IValueConverter
{
    private static readonly SolidColorBrush SuccessBrush = new(Color.FromRgb(255, 121, 0));
    private static readonly SolidColorBrush FailureBrush = new(Color.FromRgb(218, 54, 51));

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is bool isSuccess)
        {
            return isSuccess ? SuccessBrush : FailureBrush;
        }
        return FailureBrush;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
