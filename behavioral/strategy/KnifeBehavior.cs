namespace Behavioral.Strategy;

public class KnifeBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("You gettin knifed");
    }
}