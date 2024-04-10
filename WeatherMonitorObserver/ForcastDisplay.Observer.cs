namespace WeatherMonitorObserver;
public class ForecastDisplay : IDisplay
{
    private WeatherData weatherData;
    private WeatherDataInfo weatherDataInfo;

    public ForecastDisplay(WeatherData weatherData)
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
        string forecast = (weatherDataInfo.Temperature > 20) ? "Warm and sunny" : "Cool and cloudy";
        Console.WriteLine("Weather forecast:");
        Console.WriteLine(forecast);
        Console.WriteLine("");
    }
}