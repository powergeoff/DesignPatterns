namespace Structural.Decorator.Book;

public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }
    public override double Cost()
    {
        return .99;
    }
}