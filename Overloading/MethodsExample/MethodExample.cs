using Overloading.Shared;

namespace Overloading.MethodsExample;

public class MethodExample
{
    public string ProcessData(ExampleData exampleData)
    {
        return $"Name: {exampleData.Name} and Value: {exampleData.Value}. Type: {exampleData.GetType()}";
    }
    
    public string ProcessData(object exampleData)
    {
        return $"Type: {exampleData.GetType()}";
    }
    
    public string ProcessData(ExampleData exampleData, int changeValueBy)
    {
        return $"Name: {exampleData.Name} and Value: {exampleData.Value + changeValueBy}. Type: {exampleData.GetType()}";
    }
}