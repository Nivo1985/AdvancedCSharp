namespace PatternMatching.ExampleClasses;

public class SpecialOrder: Order
{
    public string ExtraRequests;
    public bool NextDayDelivery;

    public SpecialOrder(int id, string name, int numberOfItems, decimal value, string extraRequests, bool nextDayDelivery = false)
        : base(id, name, numberOfItems, value)
    {
        ExtraRequests = extraRequests;
        NextDayDelivery = nextDayDelivery;
    }
}