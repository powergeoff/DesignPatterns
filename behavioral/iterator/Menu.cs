public class Menu : MenuComponent
{
    private List<MenuComponent> _menuComponents = new List<MenuComponent>(); //this can be done in the constructor if we had multiple constructors that may or may not want the property to be initialized

    public Menu(string name, string description) : base(name, description)
    {
    }

    public override void Add(MenuComponent menuComponent)
    {
        _menuComponents.Add(menuComponent);
    }

    public override void Remove(MenuComponent menuComponent)
    {
        _menuComponents.Remove(menuComponent);
    }

    public override List<MenuComponent> GetChildren()
    {
        return _menuComponents;
    }

    public override void Print()
    {
        Console.WriteLine($"{Name.ToUpper()} MENU");
        Console.WriteLine($"------{Description}");
        foreach(var m in _menuComponents)
        {
            m.Print();
        }
    }
}