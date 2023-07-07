public class SetContrastCommand : ICommand
{
    private VideoEditor _videoEditor;
    private double _contrast;

    public SetContrastCommand(double contrast, VideoEditor videoEditor)
    {
        _videoEditor = videoEditor;
        _contrast = contrast;
    }
    public void Execute()
    {
        _videoEditor.Contrast = _contrast;
    }
}