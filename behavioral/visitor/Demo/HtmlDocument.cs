namespace Behavioral.Visitor.Demo;

public class HtmlDocument {
  private List<IHtmlNode> nodes = new List<IHtmlNode>();

  public void add(IHtmlNode node) {
    nodes.Add(node);
  }

  public void execute(IVisitor operation) {
    foreach (var node in nodes)
      node.execute(operation);
  }
}