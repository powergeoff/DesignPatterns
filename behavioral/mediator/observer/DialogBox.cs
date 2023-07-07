namespace Behavioral.Mediator.Observer;

public class DialogBox: IEventHandler {
    private TextBox _userName = new TextBox();
    private TextBox _passWord = new TextBox();
    private CheckBox _terms = new CheckBox();
    private Button _signUp = new Button();

    public DialogBox()
    {
        _userName.addEventHandler(this);
        _passWord.addEventHandler(this);
        _terms.addEventHandler(this);
        _signUp.addEventHandler(this);
    }

    public void SimulateSuccess()
    {
        _userName.Content = "GAO0";
        _passWord.Content = "whatever";
        _terms.IsChecked = true;

        Console.WriteLine("Is Sign Up Enabled expect true: " + _signUp.IsEnabled);
    }

    public void SimulateFail()
    {
        _userName.Content = "GAO0";
        _terms.IsChecked = true;

        Console.WriteLine("Is Sign Up Enabled expect false: " + _signUp.IsEnabled);
    }

    public void Handle()
    {
        if (!String.IsNullOrEmpty(_userName.Content) && !String.IsNullOrEmpty(_passWord.Content) && _terms.IsChecked)
        {
            _signUp.IsEnabled = true;
        }
        else 
        {
            _signUp.IsEnabled = false;
        }
    }

}