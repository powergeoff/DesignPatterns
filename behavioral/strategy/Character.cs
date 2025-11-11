using System.Security.AccessControl;

namespace Behavioral.Strategy;

public abstract class Character
{
    protected IWeaponBehavior _weapon;

    public Character(IWeaponBehavior weapon)
    {
        _weapon = weapon;
    }

    public virtual void Fight()
    {
        _weapon.UseWeapon();
    }
    public abstract void SetWWeapon(IWeaponBehavior w);
}