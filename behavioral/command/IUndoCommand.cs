public interface IUndoCommand: ICommand {
    void UnExecute();
}