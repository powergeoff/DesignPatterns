namespace Behavioral.Visitor.Demo;

public interface IVisitor {
    void apply(AnchorNode anchorNode);
    
    void apply(HeadingNode headingNode);

    //add more apply methods for each NODE type
}