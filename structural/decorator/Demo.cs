using Structural.Decorator.Book;

namespace Structural.Decorator;
public static class DecoratorDemo{
    public static void Run(){
        //do stuff
        StoreCreditCard(
            new CompressedCloudStream(
            new EncryptedCloudStream(
                new CloudStream()
                    )
                )
            );
    }

    private static void StoreCreditCard(IStream stream)
    {
        stream.Write("1234-1234-12345");
    }

    public static void RunBook(){
        var customOrder = new WhipDecorator((new MochaDecorator( new MochaDecorator( new SoyDecorator( 
            new HouseBlend()
        )))));
        Console.WriteLine(customOrder.Description + " : costs $" + customOrder.Cost());

        Beverage custom = new Espresso();
        custom = new WhipDecorator(custom);
        custom = new SoyDecorator(custom);

        Console.WriteLine(custom.Description + " : costs $" + custom.Cost());
    }
}

