using PatternMatching.ExampleClasses;

namespace PatternMatching.Demos;

public class PositionalPattern 
{
    public void Demo1()
    {
        var instance = new Custorem(1, "Name1",
            new Order(1, "Karol Order", 110, 500));
        var description = instance.Order switch
        {
            (var temp, >= 100, >=500) => $"The order {temp} is large and valuable",
            (_,>= 100,_) temp =>  $"The order {temp.Name} is large (ID: {temp.Id})", // values outside deconstructor
            (_,_, >=500) temp =>  $"The order {temp.Name} is valuable (ID: {temp.Id})",
            (_,_,_) temp => $"Nothing special about order {temp.Name} is valuable (ID: {temp.Id})"
        };
    }

    public void Demo2()
    {
        var instance = new Custorem(1, "Name1",
            new Order(1, "Karol Order", 90, 500));
        var instanceTuple = (instance.Order.Id, instance.Order.Name,
            instance.Order.NumberOfItems, instance.Order.Value);
        
        var description = instanceTuple switch
        {
            (_,var temp, >= 100, >=500) => $"The order {temp} is large and valuable",
            (_,_,>= 100,_) temp =>  $"The order {temp.Name} is large (ID: {temp.Id})", // values outside deconstructor
            (_,_,_, >=500) temp =>  $"The order {temp.Name} is valuable (ID: {temp.Id})",
            (_,_,_,_) temp => $"Nothing special about order {temp.Name} is valuable (ID: {temp.Id})"
        };
    }
}