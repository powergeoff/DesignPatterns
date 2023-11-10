

public class PancakeHouseMenu: IMenu {
    private List<MenuItem> _menuItems;

    public PancakeHouseMenu()
    {
        _menuItems = new List<MenuItem>();
        AddItem("Special Pancake Breakfast", "pancakes and eggs", true, 2.49);
        AddItem("Regular Breakfast", "pancakes and sausage", false, 2.99);
        AddItem("Blueberry Pancake Breakfast", "blueberry pancakes and eggs", true, 3.99);
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