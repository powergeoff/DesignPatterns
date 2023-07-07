namespace Behavioral;
public static class CORDemo{
    public static void Run(){
        //do stuff
        //auth -> logger -> compressor
        var compressor = new Compressor(null);
        var logger = new Logger(compressor);
        var auth = new Auth(logger);

        var server = new WebServer(auth);
        var httpRequest = new HttpRequest();
        httpRequest.User = "admin";
        httpRequest.Password = "12345";
        server.HandleRequest(httpRequest);
    }
}