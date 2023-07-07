namespace Behavioral.Observer;

public class Chart : IObserver
{
    public void Update()
    {
        Console.WriteLine("Chart updated!");
    }
}