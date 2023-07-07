namespace Behavioral.Visitor.Exercise;

public class FactSegment : ISegment
{
    public void Execute(IVisitor operation)
    {
        operation.ApplyFilter(this);
    }
}