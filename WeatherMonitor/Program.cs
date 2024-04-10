using System;
using WeatherMonitorObserver;


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