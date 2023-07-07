namespace Behavioral.Observer.Book;

public interface ISubject {
    void Register(IObserver o);
    void Remove(IObserver o);

    void Notify();
}