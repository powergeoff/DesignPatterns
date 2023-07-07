namespace Behavioral.Visitor.Demo;

public class HeadingNode : IHtmlNode
{
    public void execute(IVisitor operation)
    {
        operation.apply(this);
    }
}