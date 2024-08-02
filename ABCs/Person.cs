public abstract class Person
{
    List<ICommunicateBehavior> _communicateBeahviors;

    public Person()
    {
        _communicateBeahviors = new List<ICommunicateBehavior>();
    }

    public void AddCommunicationBehavior(ICommunicateBehavior communicateBehavior)
    {
        _communicateBeahviors.Add(communicateBehavior);
    }
}

//below violates ISP - don't force classes to inherit functionality they might not use
//break them out into several interfaces and use multiple interface inheritance
public interface IPersonBehaviors
{
    void Speak();
    void Exercise();
    void EatVegetables();

    void ReadBooks();
}

public interface ICommunicateBehavior
{
    void UseCommunication();
}

public class SignLanguage : ICommunicateBehavior
{
    public void UseCommunication()
    {
        Console.WriteLine("Using Sign Language");
    }
}

public class SpeakFrench : ICommunicateBehavior
{
    public void UseCommunication()
    {
        Console.WriteLine("Speaking French");
    }
}

public class SpeakEnglish : ICommunicateBehavior
{
    public static string WriteStuff()
    {
        return "Stuff";
    }
    public void UseCommunication()
    {
        Console.WriteLine("Speaking English");
    }
}

public static class PersonDemo
{
    public static void Run()
    {
        var english = new SpeakEnglish();
        //****************below is no good!
        //Console.WriteLine(english.WriteStuff());
        //**********Member 'SpeakEnglish.WriteStuff()' cannot be accessed with an instance reference; qualify it with a type name instead

        Console.WriteLine(SpeakEnglish.WriteStuff()); //this is fine
    }
}

