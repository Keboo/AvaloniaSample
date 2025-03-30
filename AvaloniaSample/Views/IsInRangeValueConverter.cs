using System.Globalization;

using Avalonia.Data.Converters;

namespace AvaloniaSample.Views;

public class IsInRangeValueConverter : IValueConverter
{
    public decimal Min { get; set; }
    public decimal Max { get; set; }

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value is decimal i && i > Min && i < Max;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
