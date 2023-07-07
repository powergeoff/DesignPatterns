namespace Structural.Adapter.Exercise;

public class GMailClient {
    public void Connect()
    {
        Console.WriteLine("Connecting to GMail");
    }
    public void GetEmails()
    {
        Console.WriteLine("Getting all Gmails");
    }
    public void Disconnet()
    {
        Console.WriteLine("Disconnecting from GMail server");
    }
}