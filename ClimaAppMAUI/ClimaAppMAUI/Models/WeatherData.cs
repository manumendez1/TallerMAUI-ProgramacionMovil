using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClimaAppMAUI.Models;

public class WeatherData : INotifyPropertyChanged
{
    private double temperature;
    private int humidity;
    private WeatherCondition condition;

    public double Temperature
    {
        get => temperature;
        set { temperature = value; OnPropertyChanged(); }
    }

    public int Humidity
    {
        get => humidity;
        set { humidity = value; OnPropertyChanged(); }
    }

    public WeatherCondition Condition
    {
        get => condition;
        set { condition = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}