namespace PatternMatching.ExampleClasses;

public class RecurentOrder: Order
{
    public Frequency Frequency;

    public RecurentOrder(int id, string name, int numberOfItems, decimal value , Frequency frequency)
        : base(id, name, numberOfItems, value)
    {
        Frequency = frequency;
    }
}


public enum Frequency
{
    Daily,
    Weekly,
    Monthly,
    Yearly
}