namespace Behavioral.Mediator;

public class TextBox: UIControl {

    private string? _content;
    public string? Content 
    { 
        get
        {
            return _content;
        } 
        set
        {
            _content = value;
            _owner.changed(this);
        }
    }


    public TextBox( DialogBox owner) : base(owner)
    {
    }

    
}