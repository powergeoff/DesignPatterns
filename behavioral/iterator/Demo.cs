public static class IteratorDemo{
    public static void Run(){
        //HUGE Refactor!
        MenuComponent pancakeMenu = new Menu("PANCAKE HOUSE", "Breakfast");
        MenuComponent dinerMenu = new Menu("diner", "Lunch");
        MenuComponent cafeMenu = new Menu("cafe", "Dinner");
        MenuComponent desertMenu = new Menu("dessert", "Dessert of course!");

        MenuComponent allMenus = new Menu("all","All Menus Combined");

        allMenus.Add(pancakeMenu);
        allMenus.Add(dinerMenu);
        allMenus.Add(cafeMenu);
        allMenus.Add(desertMenu);

        pancakeMenu.Add(new MenuItem("Special Pancake Breakfast", "pancakes and eggs", true, 2.49));
        pancakeMenu.Add(new MenuItem("Regular Breakfast", "pancakes and sausage", false, 2.99));
        pancakeMenu.Add(new MenuItem("Blueberry Pancake Breakfast", "blueberry pancakes and eggs", true, 3.99));

        dinerMenu.Add(new MenuItem("Veggie BLT", "Fakin bacon", true, 3.49));
        dinerMenu.Add(new MenuItem("BLT", "Real Bacon", false, 3.99));
        dinerMenu.Add(new MenuItem("Hot Dog", "Hot dog and beans", false, 3.99));

        cafeMenu.Add(new MenuItem("Veggie Burger and Fries", "Veggie Burger Blah Blah Blah", true, 12.49));
        cafeMenu.Add(new MenuItem("Soup Of The Day", "Some kind of Soup I guess", false, 12.99));
        cafeMenu.Add(new MenuItem("Steak and Potatoes", "Steak And Potatoes man", false, 13.99));

        desertMenu.Add(new MenuItem("Apple Pie", "Homemade Apple Pie with cinnamon", true, 5.99));
        desertMenu.Add(new MenuItem("Creme Brule", "Fancy ass shit", true, 7.99));
        desertMenu.Add(new MenuItem("Pistachio Ice Cream", "Homemade Ice Cream Churned out back", true, 15.99));

        Waitress waitress = new Waitress(allMenus);
        waitress.PrintMenu();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Vegetarian Menu");

        waitress.PrintVegetarianMenu();

        /* 
        AddItem("Veggie Burger and Fries", "Veggie Burger Blah Blah Blah", true, 12.49);
        AddItem("Soup Of The Day", "Some kind of Soup", false, 12.99);
        AddItem("Steak and Potatoes", "Steak And Potatoes ", true, 13.99);
        
        
        
        var dinerMenu = new DinerMenu();
        var pancakeMenu = new PancakeHouseMenu();
        var cafeMenu = new CafeMenu();

        Waitress waitress = new Waitress(pancakeMenu, dinerMenu, cafeMenu);

        waitress.PrintMenu(); */
    }
}