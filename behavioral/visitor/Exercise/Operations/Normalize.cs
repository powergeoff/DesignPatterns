namespace Behavioral.Visitor.Exercise;

public class Normalize : IVisitor
{

    public void ApplyFilter(FactSegment segment)
    {
        Console.WriteLine("Normalize - FACT SEGMENT");
    }

    public void ApplyFilter(FormatSegment segment)
    {
        Console.WriteLine("Normalize - FORMAT SEGMENT");
    }
}