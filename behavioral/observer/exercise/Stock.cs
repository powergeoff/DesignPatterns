namespace Behavioral.Observer;
public class Stock: Subject {
    public string Symbol { get; set; }
    private double _price;
    public Stock(string symbol)
    {
        Symbol = symbol;
    }

    public double GetPrice() 
    {
        return _price;
    }

    public void SetPrice(double price){
        _price = price;
        Notify();
    }
    public override string ToString()
    {
        return "Stock{" +
                "symbol='" + Symbol + '\'' +
                ", price=" + GetPrice() +
                '}';
    }
}