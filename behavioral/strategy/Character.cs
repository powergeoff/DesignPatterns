using System.Security.AccessControl;

namespace Behavioral.Strategy;

public abstract class Character {
    protected IWeaponBehavior _weapon;

    public Character(IWeaponBehavior weapon)
    {
        _weapon = weapon;
    }

    public abstract void Fight();
    public abstract void SetWWeapon(IWeaponBehavior w);
}