namespace WeatherMonitorObserver;
public class StatisticsDisplay : IDisplay
{
    private WeatherData weatherData;
    private List<int> temperatures = new List<int>();

    public StatisticsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        this.weatherData.RegisterObserver(this);
    }

    public void Update(WeatherDataInfo data)
    {
        temperatures.Add(data.Temperature);
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Weather statistics:");
        Console.WriteLine($"Average Temperature: {temperatures.Average()}°C");
        Console.WriteLine($"Max Temperature: {temperatures.Max()}°C");
        Console.WriteLine($"Min Temperature: {temperatures.Min()}°C");
        Console.WriteLine("");
    }
}