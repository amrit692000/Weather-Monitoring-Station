namespace WeatherMonitorObserver;

public sealed class WeatherData
{
    private static WeatherData instance;
    private List<IDisplay> observers = new List<IDisplay>();

    private WeatherData() { }

    public static WeatherData GetInstance()
    {
        if (instance == null)
            instance = new WeatherData();
        return instance;
    }

    public void RegisterObserver(IDisplay observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IDisplay observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers(WeatherDataInfo data)
    {
        foreach (var observer in observers)
        {
            observer.Display();
        }
    }

    public void MeasurementsChanged()
    {
        Random rand = new Random();
        var data = new WeatherDataInfo
        {
            Temperature = rand.Next(10, 31),
            Humidity = rand.Next(40, 81),
            Pressure = rand.Next(980, 1021)
        };
        NotifyObservers(data);
    }
}


public class WeatherDataInfo
{
    public int Temperature { get; set; }
    public int Humidity { get; set; }
    public int Pressure { get; set; }
}















      