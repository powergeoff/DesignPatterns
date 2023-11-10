

public class DinerMenu: IMenu {
    private static int MAX_ITEMS = 3;
    private int _numberOfItems = 0;
    private MenuItem[] _menuItems;

    public DinerMenu()
    {
        _menuItems = new MenuItem[MAX_ITEMS];
        
        AddItem("Veggie BLT", "Fakin bacon", true, 3.49);
        AddItem("BLT", "Real Bacon", false, 3.99);
        AddItem("Hot Dog", "Hot dog and beans", false, 3.99);

    }

    public IIterator CreateIterator()
    {
        return new DinerMenuIterator(_menuItems);
    }

    public void AddItem(string name, string desc, bool isVeg, double price)
    {
        MenuItem item = new MenuItem(name, desc, isVeg, price);

        if (_numberOfItems > MAX_ITEMS)
        {
            Console.WriteLine("Too Many Items");
        }
        else 
        {
            _menuItems[_numberOfItems] = item;
            _numberOfItems++;
        }
    }
}