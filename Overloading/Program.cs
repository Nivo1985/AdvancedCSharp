using Overloading.MethodsExample;
using Overloading.Shared;

var methodExample = new MethodExample();
var exampleData = new ExampleData()
{
    Id = 1,
    Name = "Data1",
    Value = 100
    
};
var exampleObject = new object();
Console.WriteLine(methodExample.ProcessData(exampleData));
Console.WriteLine("++++++++++++++++++++++++++");
Console.WriteLine(methodExample.ProcessData(exampleObject));
Console.WriteLine("++++++++++++++++++++++++++");
Console.WriteLine(methodExample.ProcessData(exampleData, 23));
Console.WriteLine("++++++++++++++++++++++++++");


var startDate = new DateTime(2020, 10, 6);
var endDate = new DateTime(2022, 1, 1);
var span = endDate - startDate;
Console.WriteLine($"Result is: {span}. Type is {span.GetType()}");
Console.WriteLine("++++++++++++++++++++++++++");



var operators = new OperatorsExample();
var left = new ExampleData()
{
    Id = 1,
    Name = "Name1",
    Value = 20
};

var right = new ExampleData()
{
    Id = 2,
    Name = "Name1",
    Value = 30
};
var sumResult = operators.Add(left, right);
Console.WriteLine($"Sum result: Id: {sumResult.Id} Name: {sumResult.Name} and Value: {sumResult.Value}. Type: {sumResult.GetType()}");
Console.WriteLine($"Subtract result: {operators.Substract(left, right)}");
Console.WriteLine($"AreEqualOperator result: {operators.AreEqualOperator(left,right)}");
Console.WriteLine($"AreEqualMethod result: {operators.AreEqualMethod(left,right)}");
var toIntResult = operators.CastExampleDataToInt(left);
Console.WriteLine($"CastExampleDataToInt result: {toIntResult}. Type: {toIntResult.GetType()}");
var fromStringResult = operators.CastStringToExampleData("Object from String casting");
Console.WriteLine($"CastStringToExampleData: Id: {fromStringResult.Id} Name: {fromStringResult.Name} and Value: {fromStringResult.Value}. Type: {fromStringResult.GetType()}");


Console.ReadKey();