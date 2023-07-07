public abstract class UndoCommand : IUndoCommand
{
    private History<IUndoCommand> _history;
    public UndoCommand(History<IUndoCommand> history)
    {
        _history = history;
    }
    public void Execute()
    {
        DoExecute();
        _history.Push(this);
    }

    public void UnExecute()
    {
        DoUnExecute();
        _history.Pop();
    }

    protected abstract void DoExecute();
    protected abstract void DoUnExecute();
}