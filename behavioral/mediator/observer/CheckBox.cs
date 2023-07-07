namespace Behavioral.Mediator.Observer;
public class CheckBox: UIControl {

    private bool _isChecked;
    public bool IsChecked 
    { 
        get
        {
            return _isChecked;
        } 
        set
        {
            _isChecked = value;
            notifyEventHandlers();
        }
    }
    
}