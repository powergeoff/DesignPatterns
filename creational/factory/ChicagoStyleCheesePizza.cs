namespace Creational.Factory;
//Concrete Product
public class ChicagoStyleCheesePizza: Pizza{
    public ChicagoStyleCheesePizza()
    {
        Name = "Chicago Style Cheese Pizza";
        AddTopping("Grated Parmesan");
        AddTopping("Grated Mozzarella");
        AddTopping("Tomato Chunks");
        Dough = "Deep Dish Dough";
    }
}