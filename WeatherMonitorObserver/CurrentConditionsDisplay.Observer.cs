 namespace WeatherMonitorObserver;
public class CurrentConditionsDisplay : IDisplay
{
    private WeatherData weatherData;
    private WeatherDataInfo weatherDataInfo;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        this.weatherData.RegisterObserver(this);
    }

    public void Update(WeatherDataInfo data)
    {
        weatherDataInfo = data;
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Current conditions:");
        Console.WriteLine($"Temperature: {weatherDataInfo.Temperature}°C");
        Console.WriteLine($"Humidity: {weatherDataInfo.Humidity}%");
        Console.WriteLine($"Pressure: {weatherDataInfo.Pressure} hPa");
        Console.WriteLine("");
    }
}
