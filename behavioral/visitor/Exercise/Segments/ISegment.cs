namespace Behavioral.Visitor.Exercise;

public interface ISegment {
  void Execute(IVisitor operation);
}