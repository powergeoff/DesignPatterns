namespace Behavioral.Mediator;

public class ArticlesDialogBox : DialogBox
{
    private ListBox _articlesListBox;
    private TextBox _textBox;
    private Button _button;

    public ArticlesDialogBox()
    {
        _articlesListBox = new ListBox(this);
        _textBox = new TextBox(this);
        _button = new Button(this);
    }

    public void simulateUserAction()
    {
        _articlesListBox.Selection = "Article 1";
        Console.WriteLine("TextBox: " + _textBox.Content);
        Console.WriteLine("Button: " + _button.IsEnabled);

        _articlesListBox.Selection = null;
        Console.WriteLine("Button: " + _button.IsEnabled);
    }
    public override void changed(UIControl control)
    {
        if (control == _articlesListBox)
            articleSelected();
        else if (control == _textBox)
            titleChanged();
    }

    private void titleChanged() {
        var content = _textBox.Content;
        var isEmpty = String.IsNullOrEmpty(content);
        _button.IsEnabled = !isEmpty;
    }

    private void articleSelected() {
        _textBox.Content = _articlesListBox.Selection;
        var content = _textBox.Content;
        var isEmpty = String.IsNullOrEmpty(content);
        _button.IsEnabled = !isEmpty;
    }
}