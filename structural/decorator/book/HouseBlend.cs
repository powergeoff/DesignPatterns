namespace Structural.Decorator.Book;

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "House Blend";
    }
    public override double Cost()
    {
        return .89;
    }
}