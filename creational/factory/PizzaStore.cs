namespace Creational.Factory;
//creator
public abstract class PizzaStore {
    public Pizza OrderPizza(string type)
    {
        Pizza pizza = CreatePizza(type); //call the factory method
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
    //Factory method
    protected abstract Pizza CreatePizza(string type); //child classes implement Factory method how they see fit
}