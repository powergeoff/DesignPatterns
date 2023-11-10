
public class CafeMenu: IMenu {
    private List<MenuItem> _menuItems;

    public CafeMenu()
    {
        _menuItems = new List<MenuItem>();
        AddItem("Veggie Burger and Fries", "Veggie Burger Blah Blah Blah", true, 12.49);
        AddItem("Soup Of The Day", "Some kind of Soup", false, 12.99);
        AddItem("Steak and Potatoes", "Steak And Potatoes ", true, 13.99);
    }

    public IIterator CreateIterator()
    {
        return new PancakeHouseMenuIterator(_menuItems);
    }

    public void AddItem(string name, string desc, bool isVeg, double price)
    {
        MenuItem item = new MenuItem(name, desc, isVeg, price);
        _menuItems.Add(item);
    }
}