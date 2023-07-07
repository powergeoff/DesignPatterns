namespace Behavioral.Visitor.Exercise;

public class AddReverb : IVisitor
{

    public void ApplyFilter(FactSegment segment)
    {
        Console.WriteLine("Add Verb - FACT SEGMENT");
    }

    public void ApplyFilter(FormatSegment segment)
    {
        Console.WriteLine("Add Verb - FORMAT SEGMENT");
    }
}