using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ModemPoolManager.Converters;

public class SignalBarsConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int signalBars && parameter is string barIndex && int.TryParse(barIndex, out int index))
        {
            return signalBars >= index;
        }
        return false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class SignalBarsToOpacityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int signalBars && parameter != null)
        {
            int barIndex;
            if (parameter is string strParam)
            {
                int.TryParse(strParam, out barIndex);
            }
            else if (parameter is int intParam)
            {
                barIndex = intParam;
            }
            else
            {
                return 0.25;
            }
            
            return signalBars >= barIndex ? 1.0 : 0.25;
        }
        return 0.25;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class SignalColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string colorHex && !string.IsNullOrEmpty(colorHex))
        {
            try
            {
                var color = (Color)ColorConverter.ConvertFromString(colorHex);
                return new SolidColorBrush(color);
            }
            catch
            {
                return new SolidColorBrush(Color.FromRgb(72, 79, 88));
            }
        }
        return new SolidColorBrush(Color.FromRgb(72, 79, 88));
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
