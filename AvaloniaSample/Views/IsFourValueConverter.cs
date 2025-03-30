using System.Globalization;

using Avalonia.Data.Converters;

namespace AvaloniaSample.Views;

public class IsFourValueConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value is int i && i == 4;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
