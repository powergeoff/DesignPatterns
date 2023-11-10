//this abstract class has methods for both MenuComponents (parent or node) AND child or leaf MenuItems
//Doesn't That Break The Single Responsibility Principle??
public abstract class MenuComponent {

    //operation properties for all MenuItems and some for BOTH 
    public string Name { get; set; } //both
    public string Description { get; set; } //both
    public double? Price { get; set; } //menuItem
    public bool IsVegetarian { get; set; } //menuItem

    public MenuComponent(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public abstract void Print();

    //composite methods to add, remove or get MenuComponents. These won't get used by MenuItems
    public virtual void Add(MenuComponent menuComponent)
    {
        throw new NotSupportedException();
    }

    public virtual void Remove(MenuComponent menuComponent)
    {
        throw new NotSupportedException();
    }

    public virtual List<MenuComponent>? GetChildren()
    {
        return null;
    }
}