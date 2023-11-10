public class Waitress {
    //complete refactor
    private MenuComponent _allMenus;

    public Waitress(MenuComponent allMenus)
    {
        _allMenus = allMenus;
    }

    public void PrintMenu() 
    {
        _allMenus.Print();
    }

    public void PrintVegetarianMenu() 
    {
        //this heavily relies on this reverse tree structure
        var menus = _allMenus.GetChildren();
        PrintV(menus);
    }

    private void PrintV(List<MenuComponent>? menuComponents)
    {
        if (menuComponents != null)
        {
            foreach(var m in menuComponents)
            {
                if(m is Menu)
                {
                    PrintV(m.GetChildren());
                }
                else if(m.IsVegetarian)
                {
                    m.Print();
                }
            }
        }
        
    }
    /*private IMenu _pancakeHouseMenu;
    private IMenu _dinerMenu;
    private IMenu _cafeMenu;

    public Waitress(IMenu pancakeMenu, IMenu dinerMenu, IMenu cafeMenu)
    {
        _pancakeHouseMenu = pancakeMenu;
        _dinerMenu = dinerMenu;
        _cafeMenu = cafeMenu;
    }

    public void PrintMenu()
    {
        IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
        IIterator dinerIterator = _dinerMenu.CreateIterator();
        IIterator cafeIterator = _cafeMenu.CreateIterator();

        Console.WriteLine("Breakfast Menu");
        PrintMenu(pancakeIterator);

        Console.WriteLine("Lunch Menu");
        PrintMenu(dinerIterator);

        Console.WriteLine("Dinner Menu");
        PrintMenu(cafeIterator);

    }

    private void PrintMenu(IIterator iterator)
    {
        while(iterator.HasNext())
        {
            MenuItem menuItem = (MenuItem)iterator.Next();
            Console.WriteLine($"{menuItem.Name} costs: ${menuItem.Price}");
        }
    }
    */
}