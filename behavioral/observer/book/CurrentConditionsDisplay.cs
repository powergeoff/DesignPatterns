
namespace Behavioral.Observer.Book;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private WeatherData _weatherData;
    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.Register(this);
    }
    public void Display()
    {
        Console.WriteLine("Current conditions: " + _temperature + " F degress and " + _humidity + "% humidity");
    }

    public void Update(float temp, float humidity, float pressure)
    {
        _temperature = temp;
        _humidity = humidity;
        Display();
    }

}