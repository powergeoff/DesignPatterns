using Behavioral.Strategy;

public static class StrategyDemo{
    public static void Run(){
        //do stuff
        var king = new King();
        king.Fight();
        Console.WriteLine("Change Weapon");
        king.SetWWeapon(new KnifeBehavior());
        king.Fight();
    }
}