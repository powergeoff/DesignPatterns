using Structural.Adapter.Exercise;

namespace Structural.Adapter;

public static class AdapterDemo{
    public static void Run(){
        //do stuff
        var imageView = new ImageView(new Image());
        imageView.ApplyFilter(new CaramelAdapterFilter(new ThirdParty.Caramel()));

    }

    public static void RunExercise()
    {
        var email = new EmailClient();
        //var adapter = new GmailAdapter();
        email.AddProvider(new GmailAdapter());

        email.DownloadEmails();
    }
}