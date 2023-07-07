namespace Structural.Decorator.Book;

public class MochaDecorator : Beverage
{
    private Beverage _parentBeverage; 
    public MochaDecorator(Beverage parent)
    {
        _parentBeverage = parent;
        Description = _parentBeverage.Description +  ", Mocha";
    }
    public override double Cost()
    {
        return _parentBeverage.Cost() + .20;
    }
}