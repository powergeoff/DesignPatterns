namespace Creational.Factory;
//Concrete Product
public class ChicagoStyleVeggiePizza: Pizza{
    public ChicagoStyleVeggiePizza()
    {
        Name = "Chicago Style Veggie Pizza";
        AddTopping("Grated Maaloort");
        AddTopping("Grated Olives");
        AddTopping("Grated Mozzarella");
    }
}