// See https://aka.ms/new-console-template for more information

using AnonymousTypes.Utils;

var inst1 = new { id =1, Name = "Karol"};
var inst2 = new { id =1, Name = "Karol"};
Console.WriteLine(inst1.ToString());
Console.WriteLine("inst1.Equals(inst2)");
Console.WriteLine(inst1.Equals(inst2));
Console.WriteLine("inst1 == inst2");
Console.WriteLine(inst1 == inst2);


var orders = Order.GetOrders();
var orderSummaries = orders.Select(o => new
{
    o.Id,
    Items = o.Items?.Count,
    TotalValue = o.Items?.Sum(i => i.Price)
});


var inst3 = new { id = 1, value = 10 };
var inst4 = inst3 with { value = 12 }; 

var i = 1;



