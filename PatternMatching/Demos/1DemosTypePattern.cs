using PatternMatching.ExampleClasses;

namespace PatternMatching.Demos;

public class DemosTypePattern
{
    public void Demo1()
    {
        var instance = new Custorem(1, "Cus1", 
            new SpecialOrder(1, "Spec_Order_1",3, 30,"Make it spicy"));

        Console.WriteLine($"Test for {instance.Order.Name}");
        
        Console.WriteLine(instance.Order is SpecialOrder ? "The order is special" : "The order not so special");
        Console.WriteLine(instance.Order is Order ? "It is an order" : "It is not an order");
    }
    
    public void Demo2()
    {
        var instance = new Custorem(1, "Cus1", new Order(2, "Order_2", 1 ,15));

        Console.WriteLine($"Test for {instance.Order.Name}");
        Console.WriteLine(instance.Order is SpecialOrder ? "The order is special" : "The order not so special");
        Console.WriteLine(instance.Order is Order ? "It is an order" : "It is not an order");
    }
}