public static class CommandDemo{
    public static void Run() {
        var videoEditor = new VideoEditor();
        var textHistory = new History<IUndoCommand>();
        var textCommand = new SetTextCommand("I am some text", videoEditor, textHistory);

        textCommand.Execute();

        Console.WriteLine(videoEditor.Text);

        textCommand.UnExecute();

        Console.WriteLine("new text: " + videoEditor.Text);

        textCommand.Execute();

        var contrastCommand = new SetContrastCommand(0.7, videoEditor);
        contrastCommand.Execute();

        Console.WriteLine(videoEditor.ToString());
    }
}