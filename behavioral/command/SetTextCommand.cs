public class SetTextCommand : UndoCommand
{
    private string _text;
    private VideoEditor _videoEditor;
    public SetTextCommand(string text, VideoEditor videoEditor, History<IUndoCommand> history) : base(history)
    {
        _text = text;
        _videoEditor = videoEditor;
    }

    protected override void DoExecute()
    {
        _videoEditor.Text = _text;
    }

    protected override void DoUnExecute()
    {
        _videoEditor.RemoveText();
    }
}