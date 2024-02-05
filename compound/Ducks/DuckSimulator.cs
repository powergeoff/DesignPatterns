public static class DuckSimulator {
    public static void Simulate()
    {
        IQuackable mallard = new MallardDuck();
        IQuackable redhead = new RedheadDuck();
        IQuackable duckCall = new DuckCall();
        IQuackable rubberDuck = new RubberDuck();
        IQuackable gooseDuck = new GooseAdapter(new Goose());

        Simulate(mallard);
        Simulate(redhead);
        Simulate(duckCall);
        Simulate(rubberDuck);
        Simulate(gooseDuck);
    }

    private static void Simulate(IQuackable quack)
    {
        quack.Quack();
    }
}