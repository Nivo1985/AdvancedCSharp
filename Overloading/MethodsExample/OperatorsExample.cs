using Overloading.Shared;

namespace Overloading.MethodsExample;

public class OperatorsExample
{
    public bool AreEqualOperator(ExampleData left, ExampleData right)
    {
        return left == right;
    }
    
    public bool AreEqualMethod(ExampleData left, ExampleData right)
    {
        return left.Equals(right);
    }
    public ExampleData Add(ExampleData left, ExampleData right)
    {
        return left + right;
    }

    public int Substract(ExampleData left, ExampleData right)
    {
        return left - right;
    }

    public int CastExampleDataToInt(ExampleData exampleData)
    {
        int result = exampleData;
        return result;
    }

    public ExampleData CastStringToExampleData(string name)
    {
        var result = (ExampleData)name;
        return result;
    }
}