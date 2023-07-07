namespace Creational.Factory;
//concrete creator
public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        if (type == "cheese")
            return new ChicagoStyleCheesePizza();
        else    
            return new ChicagoStyleVeggiePizza();
    }
}