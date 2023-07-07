namespace Behavioral.Visitor.Exercise;

public interface IVisitor {
    void ApplyFilter(FactSegment factSegment);
    void ApplyFilter(FormatSegment formatSegment);

    //add more apply methods for each NODE type
}