namespace Creational.Singleton;

public sealed class NotThreadSafeSingleton {
    private static NotThreadSafeSingleton? instance = null;

    private NotThreadSafeSingleton() {}
    public static NotThreadSafeSingleton Instance {
        get {
            if (instance == null) {
                instance = new NotThreadSafeSingleton();
            }
            return instance;
        }
    }
}

public sealed class Singleton
{
    //https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/
    private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
    private Singleton()
    {
    }

    
    public static Singleton Instance
    {
        get
        {
            return lazy.Value;
        }
    }
}