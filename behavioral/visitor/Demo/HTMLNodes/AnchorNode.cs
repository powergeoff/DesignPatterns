namespace Behavioral.Visitor.Demo;
public class AnchorNode : IHtmlNode
{
    public void execute(IVisitor operation)
    {
        operation.apply(this);
    }
}