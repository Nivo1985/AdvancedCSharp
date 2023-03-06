using PatternMatching.ExampleClasses;

namespace PatternMatching.Demos;

public class DemosPropertyPattern 
{
    public void Demo1()
    {
        var instance = new Custorem(1, "Name1",
            new RecurentOrder(1, "Spec_Order_1",4,10, Frequency.Weekly));
        var description = instance.Order switch
        {
            RecurentOrder {Frequency:Frequency.Daily} => "Recurent Daily",
            RecurentOrder {Frequency:Frequency.Weekly} => "Recurent Weekly",
            RecurentOrder {Frequency:Frequency.Monthly} => "Recurent Monthly",
            RecurentOrder {Frequency:Frequency.Yearly} => "Recurent Yearly",
            SpecialOrder {NextDayDelivery: true, Value: >100} => "Make it next day",
            Order => "Just a normal order"
        };
    }

    public void Demo2()
    {
        var instance = new Custorem(1, "Name1",
            new SpecialOrder(1, "Spec_Order_1",3, 30,"Make it spicy",true));
        var instanceTuple = (instance.Order.Id, instance.Order.Name,
            instance.Order.NumberOfItems, instance.Order.Value);
        
        var description = instance.Order switch
        {
            RecurentOrder {Frequency:Frequency.Daily} => "Recurent Daily",
            RecurentOrder {Frequency:Frequency.Weekly} => "Recurent Weekly",
            RecurentOrder {Frequency:Frequency.Monthly} => "Recurent Monthly",
            RecurentOrder {Frequency:Frequency.Yearly} => "Recurent Yearly",
            SpecialOrder {NextDayDelivery: true, Value: >100} => "Make it next day",
            not null => "Just a normal order" // null check
        };
    }
}