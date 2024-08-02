public abstract class Animal
{
    public virtual void Poop()
    {
        Console.WriteLine("Animal is defecating");
    }
    public abstract void animalSound();
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

public class Pig : Animal
{
    public override void Poop()
    {
        Console.WriteLine("The pig is doing #2");
    }
    public override void animalSound()
    {
        Console.WriteLine("The pig says oink");
    }
}

public class AnimalDemo
{
    public static void Run()
    {
        //Animal myAnimal = new Animal();  // Create a Animal object
        Animal myPig = new Pig();  // Create a Pig object

        //myAnimal.animalSound();
        myPig.animalSound();
        myPig.sleep();
        myPig.Poop();

    }
}