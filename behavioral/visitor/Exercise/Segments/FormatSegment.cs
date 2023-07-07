namespace Behavioral.Visitor.Exercise;

public class FormatSegment : ISegment
{
    public void Execute(IVisitor operation)
    {
        operation.ApplyFilter(this);
    }
}