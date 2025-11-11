public class TextEditor
{
    private string? _content;

    public void Write(string text)
    {
        _content = text;
    }

    public string? GetContent()
    {
        return _content;
    }

    public EditorMemento SaveToMemento()
    {
        return new EditorMemento(_content ?? "");
    }

    public void RestoreFromMemento(EditorMemento memento)
    {
        _content = memento.State;
    }
}