namespace Behavioral;
public class Auth : Handler
{
    public Auth(Handler? next): base(next)
    {
        
    }
    protected override bool DoHandle(HttpRequest request)
    {
        var isValid = request.User == "admin" && request.Password == "1234";
        Console.WriteLine("Auth: " + isValid);
        return !isValid;
    }
}