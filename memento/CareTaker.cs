public class CareTaker
{
    private Stack<EditorMemento> _history;

    public CareTaker()
    {
        _history = new Stack<EditorMemento>();
    }

    public void SaveState(TextEditor editor)
    {
        _history.Push(editor.SaveToMemento());
    }

    public void Undo(TextEditor editor)
    {
        _history.Pop();
        var undone = _history.Peek();
        editor.RestoreFromMemento(undone);
    }
}