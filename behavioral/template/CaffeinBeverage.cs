
public abstract class CaffeinBeverage{
    //hook variable
    protected bool NeedsCondiments { get; set; }
    //set in concrete classes
    protected string? Condiments { get; set; }

    public void AskForCondiments()
    {
        //hook method - maybe not truly a hook??
        //hooks are defined as set in in subclasses to hook into template method
        //I think it is a hook - we don't have to call it
        Console.WriteLine($"Do you want {Condiments}? Y/N");
        var question = Console.ReadLine();
        if (question?.ToLower() == "y")
        {
            NeedsCondiments = true;
        }
        else
        {
            NeedsCondiments = false;
        }
    }
    public void Prepare() {
        //template method
        boilWater();
        //hollywood principle - high level component calls low level component
        brew();
        pourInCup();
        //implement the hook in subclasses
        if (NeedsCondiments) 
        {
            //hollywood principle - high level component calls low level component
            addCondiments();
        }
    }

    private void boilWater()
    {
        Console.WriteLine("Boiling water...");
    }

    private void pourInCup()
    {
        Console.WriteLine("Pouring in cup...");
    }
    protected abstract void brew();
    protected abstract void addCondiments();
}