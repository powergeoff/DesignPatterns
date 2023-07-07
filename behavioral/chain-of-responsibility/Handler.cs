namespace Behavioral;

public abstract class Handler {
    private Handler? _next;

    public Handler(){}
    public Handler(Handler? next)
    {
        _next = next;
    }

    public void Handle(HttpRequest request) 
    {
        if (DoHandle(request))
            return;
        if (_next != null)
            _next.Handle(request);

    }

    protected abstract bool DoHandle(HttpRequest request);
}