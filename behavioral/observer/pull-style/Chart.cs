
namespace Behavioral.Observer.PullStyle;
public class Chart : IObserver
{
    private DataSource _data;
    //pull style - each concrete observer has a ref to the concrete DataSource
    //on update - it will only update the values it needs

    public Chart(DataSource data)
    {   
        _data = data;
        
    }
    public void Update()
    {
        Console.WriteLine("Chart updated: " + _data.Value);
    }
}