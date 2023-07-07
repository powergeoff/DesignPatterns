namespace Behavioral.Visitor.Exercise;

public class ReduceNoise : IVisitor
{

    public void ApplyFilter(FactSegment segment)
    {
        Console.WriteLine("Reduce Noise - FACT SEGMENT");
    }

    public void ApplyFilter(FormatSegment segment)
    {
        Console.WriteLine("Reduce Noise - FORMAT SEGMENT");
    }
}