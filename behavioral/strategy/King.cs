namespace Behavioral.Strategy;

public class King : Character
{
    public King() : base(new SwordBehavior())
    {
    }
    public King(IWeaponBehavior weapon) : base(weapon)
    {
    }

    public override void SetWWeapon(IWeaponBehavior w)
    {
        _weapon = w;
    }

    public override void Fight()
    {
        _weapon.UseWeapon();
        _weapon.UseWeapon();
        SetWWeapon(new KnifeBehavior());
        _weapon.UseWeapon();
    }
}