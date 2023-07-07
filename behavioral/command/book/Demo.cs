public static class BookCommandDemo{
    public static void Run() {
        var bathroomLight = new Light();
        var brLightOnCommand = new LightOnCommand(bathroomLight);
        var remote = new RemoteControl(brLightOnCommand);

        Console.WriteLine("Is bathroom light on? " + bathroomLight.IsOn);

        remote.ButtonPressed();
        
        Console.WriteLine("Is bathroom light on now? " + bathroomLight.IsOn);
    }
}