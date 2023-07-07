namespace Behavioral.Strategy;

public class SwordBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("Sword sound");
    }
}