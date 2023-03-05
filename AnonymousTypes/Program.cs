// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using AnonymousTypes.Utils;

// // AnonymousTypes START
// var inst1 = new { id =1, Name = "Karol"};
// var inst2 = new { id =1, Name = "Karol"};
// Console.WriteLine(inst1.ToString());
// Console.WriteLine("inst1.Equals(inst2)");
// Console.WriteLine(inst1.Equals(inst2));
// Console.WriteLine("inst1 == inst2");
// Console.WriteLine(inst1 == inst2);
//
//
// var orders = Order.GetOrders();
// var orderSummaries = orders.Select(o => new
// {
//     o.Id,
//     Items = o.Items?.Count,
//     TotalValue = o.Items?.Sum(i => i.Price)
// });
//
//
// var inst3 = new { id = 1, value = 10 };
// var inst4 = inst3 with { value = 12 };
// Console.WriteLine(inst3.ToString());
// Console.WriteLine(inst4.ToString());
// // AnonymousTypes END
// // Tuples START
var order = Order.GetOrders().FirstOrDefault();
if (order != null)
{
    var example1 = (OrderId: order.Id, OrderName: order.Name, ItemsCount: order.Items!.Count);

    Console.WriteLine("example1");
    Console.WriteLine(example1);
    example1.ItemsCount++;
    Console.WriteLine(example1);
    example1.ItemsCount--;

    var example2 = (OrderId: order.Id,OrderName: order.Name,ItemsCount: order.Items!.Count);
    Console.WriteLine("example1 == example2");
    Console.WriteLine(example1 == example2);

    
    var jsonTP = JsonSerializer.Serialize(example1);
    Console.WriteLine("Tuple serialized");
    Console.WriteLine(jsonTP);
    var exampleAT = new { OrderId = order.Id, OrderName = order.Name, ItemsCount = order.Items!.Count };
    var jsonAT = JsonSerializer.Serialize(exampleAT);
    Console.WriteLine("Anonymus serialized");
    Console.WriteLine(jsonAT);
    
    
    Console.WriteLine(TupleMethod(example1).ToOneString());
}

// Tuples END
var i = 1;

static ValueTuple<int,string, string> TupleMethod((int Input_OrderId, string Input_OrderName, int Input_ItemsCount) input)
{
    return (input.Input_OrderId, input.Input_OrderName, input.Input_ItemsCount.ToString());
}




