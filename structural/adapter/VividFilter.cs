namespace Structural.Adapter;

public class VividFilter : IFilter
{
    public void Apply(Image image)
    {
        Console.WriteLine("Applying Vivd Filter");
    }
}