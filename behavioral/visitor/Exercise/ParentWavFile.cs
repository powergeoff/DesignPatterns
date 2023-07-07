namespace Behavioral.Visitor.Exercise;

public class WavFile {
  private List<ISegment> _segments = new List<ISegment>();

  public void Add(ISegment segment) {
    _segments.Add(segment);
  }

  public void Filter(IVisitor operation) {
    foreach (var segment in _segments)
      segment.Execute(operation);
  }
}