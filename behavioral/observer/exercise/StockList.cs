namespace Behavioral.Observer;
public class StockList : IObserver
{
    private List<Stock> _stockList = new List<Stock>();

    public void AddStock(Stock stock){
        _stockList.Add(stock);
    }
    
    public void Update()
    {
        foreach(var stock in _stockList)
        {
            Console.WriteLine("Update! " + stock.ToString());
        }
    }
}