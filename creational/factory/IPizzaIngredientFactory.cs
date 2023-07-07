namespace Creational.Factory;

public interface IPizzaIngredientFactory{
    public IDough CreateDough();
    public ICheese CreateCheese();
    public ISauce CreateSauce();

}