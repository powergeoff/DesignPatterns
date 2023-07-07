namespace Structural.Composite;

public static class CompositeDemo{
    public static void Run(){
        var group = new Group("Master");
        var circleGroup = new Group("Circle Group");
        var squareGroup = new Group("Square Group");

        var squar1 = new Shape("Square 1");
        var squar2 = new Shape("Square 2");

        var circle1 = new Shape("Circle 1");
        var circle2 = new Shape("Circle 2");

        squareGroup.Add(squar1);
        squareGroup.Add(squar2);

        circleGroup.Add(circle1);
        circleGroup.Add(circle2);

        group.Add(circle2);
        group.Add(squareGroup);
        group.Add(circleGroup);

        group.Render();
    }
}