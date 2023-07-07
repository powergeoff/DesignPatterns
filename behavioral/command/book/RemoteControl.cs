public  class RemoteControl{
    private ICommand _slot;

    public RemoteControl(ICommand command)
    {
        _slot = command;
    }

    public void ButtonPressed()
    {
        _slot.Execute();
    }
}