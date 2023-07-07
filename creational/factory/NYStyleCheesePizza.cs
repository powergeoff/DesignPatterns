namespace Creational.Factory;
//Concrete Product
public class NYStyleCheesePizza: Pizza{
    public NYStyleCheesePizza()
    {
        Name = "NY Style Cheese Pizza";
        AddTopping("Grated Parmesan");
        AddTopping("Grated Reggiano");
        AddTopping("Grated Mozzarella");
    }
}