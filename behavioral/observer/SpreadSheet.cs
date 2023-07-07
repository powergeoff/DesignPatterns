namespace Behavioral.Observer;

public class SpreadSheet : IObserver
{
    //public int MyProperty { get; set; }
    public void Update()
    {
        Console.WriteLine("Spreadsheet Updated!");
    }
}