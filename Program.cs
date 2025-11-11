using Behavioral;
using Structural;
internal class Program
{
    private static void Main(string[] args)
    {
        //Behavioral.Observer.ObserverDemo.Run();
        /*Behavioral.Mediator.MediatorDemo.Run();
       Behavioral.Mediator.MediatorDemo.RunObserver();
       CORDemo.Run();
       Behavioral.Visitor.Demo.VisitorDemo.Run();
       Behavioral.Visitor.Exercise.VisitorExerciseDemo.Run(); */

        StrategyDemo.Run();
        //Structural.Composite.CompositeDemo.Run();
        //Structural.Adapter.AdapterDemo.Run();
        //Structural.Adapter.AdapterDemo.RunExercise();
        //Structural.Decorator.DecoratorDemo.Run();
        //Structural.Decorator.DecoratorDemo.RunBook();
        //Creational.Factory.Demo.Run();

        //FWDemo.Run();

        //TemplateDemo.Run();

        //IteratorDemo.Run();


        //Division.Exercise(2,2);

        //DuckSimulator.Simulate();
        //AnimalDemo.Run();
        //PersonDemo.Run();
        var history = new CareTaker();
        var editor = new TextEditor();
        editor.Write("Hello World!");
        history.SaveState(editor);
        editor.Write("Hello everyone!");
        history.SaveState(editor);

        history.Undo(editor);

        Console.WriteLine(editor.GetContent());
    }
}