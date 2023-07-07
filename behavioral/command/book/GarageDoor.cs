public class GarageDoor{
    public Light Light = new Light();


    public void Up()
    {
        Console.WriteLine("Garage door going up");
    }
    public void Down(){}
    public void Stop(){}
    public void LightOn()
    {
        Light.SwitchOn();
    }
    public void LightOff()
    {
        Light.SwitchOff();
    }
}