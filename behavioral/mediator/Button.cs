namespace Behavioral.Mediator;

public class Button: UIControl {
    private bool _isEnabled;

    public bool IsEnabled 
    { 
        get
        {
            return _isEnabled;
        }
        set
        {
            _isEnabled = value;
            _owner.changed(this);
        }
    }

    public Button(DialogBox owner) : base(owner)
    {
        _isEnabled = false;
    }

}