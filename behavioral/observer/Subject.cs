namespace Behavioral.Observer;

public abstract class Subject {
    private List<IObserver> _observers = new List<IObserver>();
    public void AddObserver(IObserver observer){
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer) {
        _observers.Remove(observer);
    }

    protected void Notify() {
        foreach(var observer in _observers){
            observer.Update();
        }
    }
}