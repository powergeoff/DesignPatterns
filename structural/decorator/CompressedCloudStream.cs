namespace  Structural.Decorator;

public class CompressedCloudStream : IStream
{
    private IStream _stream;

    public CompressedCloudStream(IStream stream)
    {
        _stream = stream;
    }
    public void Write(string data)
    {
        var compressed = Compress(data);
        _stream.Write(compressed);
    }
    private string Compress(string data)
    {
        return "Compressed Data: " + data.Substring(0,5);
    }
}