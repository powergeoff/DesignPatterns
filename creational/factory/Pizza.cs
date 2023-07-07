namespace Creational.Factory;
//Product
public abstract class Pizza{
    
    public string? Dough { get; set; }
    public string? Sauce { get; set; }
    public string? Name { get; set; }


    private List<Topping> _toppings = new List<Topping>();

    public void AddTopping(string name)
    {
        _toppings.Add(new Topping(name));
    }
    
    public void Prepare() 
    {
        Console.WriteLine("Preparing " + Name);
        foreach(var topping in _toppings)
        {
            Console.WriteLine(topping.Name);
        }
    }

    public void Bake()
    {
        Console.WriteLine("Baking you pizza...");
    }
    
    public void Box()
    {
        Console.WriteLine("Boxing you pizza...");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting a you pizza...");
    }
}