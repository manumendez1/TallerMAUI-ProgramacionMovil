using ClimaAppMAUI.Models;

namespace ClimaAppMAUI;

public partial class MainPage : ContentPage
{
    private WeatherData weatherData;
    private readonly WeatherCondition[] conditions = Enum.GetValues<WeatherCondition>();

    public MainPage()
    {
        InitializeComponent();

        weatherData = new WeatherData
        {
            Temperature = 24.5,
            Humidity = 65,
            Condition = WeatherCondition.PartlyCloudy
        };

        this.BindingContext = weatherData;
    }

    private void OnActualizarClicked(object? sender, EventArgs e)
    {
        var random = new Random();
        weatherData.Temperature = random.Next(15, 35) + random.NextDouble();
        weatherData.Humidity = random.Next(40, 90);
        weatherData.Condition = conditions[random.Next(conditions.Length)];
    }
}