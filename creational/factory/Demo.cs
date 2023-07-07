namespace Creational.Factory;

public static class Demo{
    public static void Run(){
        //do stuff
        var nyPizzaStore = new NYPizzaStore();
        var nyCheese = nyPizzaStore.OrderPizza("cheese");

        var chPizzaStore = new ChicagoPizzaStore();
        var chVeggie = chPizzaStore.OrderPizza("veggie");
    }
}