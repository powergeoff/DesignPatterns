namespace  Structural.Decorator;

public class CloudStream : IStream
{
    public void Write(string data)
    {
        Console.WriteLine("Writing Cloud: " + data);
    }
}