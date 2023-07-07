namespace Behavioral;
public class Compressor : Handler
{
    
    public Compressor(Handler? next): base(next)
    {
        
    }
    protected override bool DoHandle(HttpRequest request)
    {
        var isValid = request.User == "admin" && request.Password == "1234";
        Console.WriteLine("Compressing: " + isValid);
        return false;
    }
}