namespace WeatherMonitorObserver;
public class WeatherStation
{
    public IDisplay CreateDisplay(string displayType, WeatherData weatherData)
    {
        switch (displayType)
        {
            case "CurrentConditions":
                return new CurrentConditionsDisplay(weatherData);
            case "Statistics":
                return new StatisticsDisplay(weatherData);
            case "Forecast":
                return new ForecastDisplay(weatherData);
            default:
                throw new ArgumentException("Invalid display type");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        WeatherData weatherData = WeatherData.GetInstance();
        WeatherStation weatherStation = new WeatherStation();

        IDisplay currentConditionsDisplay = weatherStation.CreateDisplay("CurrentConditions", weatherData);
        IDisplay statisticsDisplay = weatherStation.CreateDisplay("Statistics", weatherData);
        IDisplay forecastDisplay = weatherStation.CreateDisplay("Forecast", weatherData);

        weatherData.MeasurementsChanged();
    }
}