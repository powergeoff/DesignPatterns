using System.ComponentModel.DataAnnotations;

namespace   Structural.Adapter.Exercise;

public class EmailClient{
    private List<IEmailProvider> _providers = new List<IEmailProvider>();

    public void AddProvider(IEmailProvider provider)
    {
        _providers.Add(provider);
    }

    public void DownloadEmails() 
    {
        foreach(var p in _providers)
        {
            p.DownloadEmails();
        }
    }
}