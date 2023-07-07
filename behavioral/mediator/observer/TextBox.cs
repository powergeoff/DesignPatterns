namespace Behavioral.Mediator.Observer;
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
            notifyEventHandlers();
        }
    }
    
}