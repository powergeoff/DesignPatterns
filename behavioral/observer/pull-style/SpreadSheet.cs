namespace Behavioral.Observer.PullStyle;

public class SpreadSheet : IObserver
{
    private DataSource _data;
    //pull style - each concrete observer has a ref to the concrete DataSource
    //on update - it will only update the values it needs

    public SpreadSheet(DataSource data)
    {   
        _data = data;
        
    }
    public void Update()
    {
        Console.WriteLine("Spreadsheet Updated!" + _data.Value);
    }
}