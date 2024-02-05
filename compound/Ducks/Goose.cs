public class Goose{
    public void Honk()
    {
        Console.WriteLine("Honk");
    }
}

public class GooseAdapter : IQuackable{
    private Goose _goose;

    public GooseAdapter(Goose goose)
    {
        _goose = goose;
    }

    public void Quack()
    {
        _goose.Honk();
    }
}