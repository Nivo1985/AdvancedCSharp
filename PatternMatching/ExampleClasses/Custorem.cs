namespace PatternMatching.ExampleClasses;

public class Custorem
{
    public int Id;
    public string Name;
    public Order Order;

    public Custorem(int id, string name, Order  order)
    {
        Id = id;
        Name = name;
        Order = order;
    }
}