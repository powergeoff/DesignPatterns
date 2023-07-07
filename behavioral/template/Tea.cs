public class Tea : CaffeinBeverage
{
    public Tea()
    {
        Condiments = "lemon";
    }
    protected override void addCondiments()
    {
        Console.WriteLine($"Adding {Condiments}...");
    }

    protected override void brew()
    {
        Console.WriteLine("Brewing up yo tea!");
    }
}
