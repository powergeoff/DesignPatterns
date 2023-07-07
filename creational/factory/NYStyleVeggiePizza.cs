namespace Creational.Factory;
//Concrete Product
public class NYStyleVeggiePizza: Pizza{
    public NYStyleVeggiePizza()
    {
        Name = "NY Style Veggie Pizza";
        AddTopping("Grated Onions");
        AddTopping("Grated Peppers");
        AddTopping("Grated Mozzarella");
    }
}