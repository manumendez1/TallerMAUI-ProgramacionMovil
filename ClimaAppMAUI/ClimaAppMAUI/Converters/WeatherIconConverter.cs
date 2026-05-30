using ClimaAppMAUI.Models;
using System.Globalization;

namespace ClimaAppMAUI.Converters;

public class WeatherIconConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is WeatherCondition condition)
        {
            return condition switch
            {
                WeatherCondition.Sunny => "☀️ Soleado",
                WeatherCondition.PartlyCloudy => "🌤️ Parcialmente nublado",
                WeatherCondition.Cloudy => "☁️ Nublado",
                WeatherCondition.Rainy => "🌧️ Lluvioso",
                WeatherCondition.Stormy => "⛈️ Tormenta",
                _ => "🌡️ Desconocido"
            };
        }
        return string.Empty;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => throw new NotImplementedException();
}