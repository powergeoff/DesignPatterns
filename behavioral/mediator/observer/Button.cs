namespace Behavioral.Mediator.Observer;
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
            //notifyEventHandlers();
        }
    }
    
}