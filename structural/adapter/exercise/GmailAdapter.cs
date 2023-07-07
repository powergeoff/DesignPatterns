namespace Structural.Adapter.Exercise;

public class GmailAdapter : IEmailProvider
{
    private GMailClient _client = new GMailClient();

    public GmailAdapter()
    {
    }
    public GmailAdapter(GMailClient client)
    {
        _client = client;
    }
    public void DownloadEmails()
    {
        _client.Connect();
        _client.GetEmails();
        _client.Disconnet();
    }
}