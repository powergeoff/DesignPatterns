namespace  Structural.Decorator;

public class EncryptedCloudStream : IStream
{
    private IStream _stream;

    public EncryptedCloudStream(IStream stream)
    {
        _stream = stream;
    }
    public void Write(string data)
    {
        var encrypted = Encrypt(data);
        _stream.Write(encrypted);
    }
    private string Encrypt(string data)
    {
        return "Phony Encrypted Data: %^&$f $#@ nn *";
    }
}