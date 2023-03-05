namespace PatternMatching.ExampleClasses;

public class Order
{
    public int Id;
    public string Name;
    public int NumberOfItems;
    public decimal Value;

    public Order(int id, string name, int numberOfItems, decimal value)
    {
        Id = id;
        Name = name;
        NumberOfItems = numberOfItems;
        Value = value;
    }
    
    public void Deconstruct(out string name, out int numberOfItems, out decimal value)
    {
        name = Name;
        numberOfItems = NumberOfItems;
        value = Value;
    }
}