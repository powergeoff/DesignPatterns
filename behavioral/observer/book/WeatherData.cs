namespace Behavioral.Observer.Book;

public class WeatherData : ISubject
{

    private List<IObserver> _observers = new List<IObserver>();
    private float _temperature;
    private float _humidity;
    private float _pressure;
    public void Notify()
    {
        foreach(var o in _observers)
        {
            o.Update(_temperature, _humidity, _pressure);
        }
    }

    public void Register(IObserver o)
    {
        _observers.Add(o);
    }

    public void Remove(IObserver o)
    {
        _observers.Remove(o);
    }

    public void MeasurementsChanged() {
        Notify();
    }

    public void SetMeasurements(float temp, float humidity, float pressure)
    {
        _temperature = temp;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }
}