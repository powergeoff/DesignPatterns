public interface IQuackable {
    void Quack();
}

public class MallardDuck : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}

public class RedheadDuck : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}

public class DuckCall : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Kwak");
    }
}

public class RubberDuck : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Squeek");
    }
}