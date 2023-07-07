namespace Structural.Decorator.Book;

public class WhipDecorator : Beverage
{
    private Beverage _parentBeverage; 
    public WhipDecorator(Beverage parent)
    {
        _parentBeverage = parent;
        Description = _parentBeverage.Description +  ", Whip";
    }
    public override double Cost()
    {
        return _parentBeverage.Cost() + .10;
    }
}