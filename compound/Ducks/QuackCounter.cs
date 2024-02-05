public class QuackCounter : IQuackable {
    private IQuackable _duck;
    private static int _numberOfQuacks;

    public QuackCounter(IQuackable duck)
    {
        _duck = duck;
    }

    public void Quack()
    {
        _numberOfQuacks++;
        _duck.Quack();
    }

    public static int GetQuacks() => _numberOfQuacks;
}