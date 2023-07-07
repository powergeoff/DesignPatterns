namespace Behavioral.Visitor.Demo;

public class HighlightOperation: IVisitor {
  public void apply(HeadingNode heading) {
    Console.WriteLine("highlight-heading");
  }

  public void apply(AnchorNode anchor) {
    Console.WriteLine("highlight-anchor");
  }
}