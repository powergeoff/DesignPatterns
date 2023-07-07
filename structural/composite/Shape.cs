namespace Structural.Composite;

public class Shape : IComponent{
    private string _name = "Shape";
    
    public string Name { get => _name; set => _name = value; }

    public Shape()
    {
        
    }

    public Shape(string name)
    {
        _name = name;
    }

    public void Render() 
    {
        Console.WriteLine("Render: " + Name);
    }
}