public class MenuItem: MenuComponent {

    public MenuItem(string name, string desc, bool isVeg, double price): base(name, desc)
    {
        IsVegetarian = isVeg;
        Price = price; 
    }

    public override void Print()
    {
        Console.WriteLine($"{Name}, IsVeg:{IsVegetarian}, cost: ${Price}");
    }
}