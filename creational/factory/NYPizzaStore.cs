namespace Creational.Factory;
//concrete creator
public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        if (type == "cheese")
            return new NYStyleCheesePizza();
        else    
            return new NYStyleVeggiePizza();
    }
}