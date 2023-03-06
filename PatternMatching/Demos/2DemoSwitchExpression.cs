using PatternMatching.ExampleClasses;

namespace PatternMatching.Demos;

public class DemoSwitchExpression 
{
    public void Demo1()
    {
        var instance = new Custorem(1, "Cus1"
            , new RecurentOrder(1, "Spec_Order_1",4,10, Frequency.Weekly));
        var description = instance.Order switch
        {
            SpecialOrder { NextDayDelivery: true } => "Spacial with next day delivery",
            SpecialOrder => "Spacial",
            RecurentOrder => "Recurent",
            Order => "Plain",
            _ => "WTF"
        };
        Console.WriteLine(description);
    }
}