namespace Behavioral.Visitor.Demo;

public static class VisitorDemo{
    public static void Run(){
        //do stuff
        var document = new HtmlDocument();
        document.add(new HeadingNode());
        document.add(new AnchorNode());

        document.execute(new HighlightOperation());

        document.execute(new PlainTextOperation());
    }
}