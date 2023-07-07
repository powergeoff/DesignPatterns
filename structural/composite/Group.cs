namespace Structural.Composite;

public class Group: IComponent {
    private List<IComponent> _components = new List<IComponent>();
    private string _name = "Group";
    public string Name { get => _name; set => _name = value; }

    public Group()
    {
        
    }
    public Group(string name)
    {
        _name = name;
    }


    public void Add(IComponent component)
    {
        _components.Add(component);
    }
    public void Render() 
    {
        Console.WriteLine("Container Name: " + Name);
        foreach(var component in _components)
        {
            component.Render();
        }
    }
}