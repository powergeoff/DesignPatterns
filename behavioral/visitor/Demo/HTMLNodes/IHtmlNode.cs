namespace Behavioral.Visitor.Demo;

public interface IHtmlNode {
  void execute(IVisitor operation);
}