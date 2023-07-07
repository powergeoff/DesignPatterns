public class Coffee : CaffeinBeverage
{
    public Coffee()
    {
        Condiments = "cream and sugar";
    }
    protected override void addCondiments()
    {
        Console.WriteLine($"Adding {Condiments}...");
    }

    protected override void brew()
    {
        Console.WriteLine("Brewing up yo covfeffee!");
    }
}
