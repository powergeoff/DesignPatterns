namespace Behavioral.Visitor.Demo;

public class PlainTextOperation: IVisitor {
  public void apply(HeadingNode heading) {
    Console.WriteLine("plain-test-heading");
  }

  public void apply(AnchorNode anchor) {
    Console.WriteLine("plain-test-anchor");
  }
}