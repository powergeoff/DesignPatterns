
public class Light{
    public bool IsOn { 
        get; private set; }

    public Light()
    {
        IsOn = false;
    }

    public void SwitchOn()
    {
        IsOn = true;
    }

    public void SwitchOff()
    {
        IsOn = false;
    }
}