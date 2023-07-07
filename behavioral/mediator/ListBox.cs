namespace Behavioral.Mediator;

public class ListBox: UIControl {
    private string? _selection;

    public string? Selection 
    { 
        get
        {
            return _selection;
        } 
        set
        {
            _selection = value;
            _owner.changed(this);
        }
    }
    public ListBox(DialogBox owner) : base(owner)
    {
    }
    
}