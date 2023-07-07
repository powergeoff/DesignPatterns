namespace Structural.Decorator.Book;

public abstract class Beverage{
    private string _description = "Unknown Beverage";

    public string Description 
    { 
        get
        { 
            return _description;
        } 
        set
        {
            _description = value;
        } 
    }

    public abstract double Cost();
}