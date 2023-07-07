namespace Behavioral.Observer.Book;

public interface IObserver{
    void Update(float temp, float humidity, float pressure);
}