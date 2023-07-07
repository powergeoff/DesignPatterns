namespace Structural.Decorator.Book;

public class SoyDecorator : Beverage
{
    private Beverage _parentBeverage; 
    public SoyDecorator(Beverage parent)
    {
        _parentBeverage = parent;
        Description = _parentBeverage.Description +  ", Soy";
    }
    public override double Cost()
    {
        return _parentBeverage.Cost() + .15;
    }
}