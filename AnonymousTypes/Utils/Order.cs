namespace AnonymousTypes.Utils;

public class Order
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Item>? Items { get; set; }
    public static List<Order> GetOrders() =>
                      new List<Order>()
                      {
                          new Order()
                          {
                              Id = 1,
                              Name = "Order1",
                              Items = new List<Item>()
                              {
                                  new Item()
                                  {
                                      Id = 11,
                                      Name = "Item 11",
                                      Price = 11
                                  }
                              }
                          },
                          new Order()
                          {
                              Id = 2,
                              Name = "Order2",
                              Items = new List<Item>()
                              {
                                  new Item()
                                  {
                                      Id = 21,
                                      Name = "Item 21",
                                      Price = 21
                                  },
                                  new Item()
                                  {
                                      Id = 22,
                                      Name = "Item 22",
                                      Price = 22
                                  }
                              }
                          },
                          new Order()
                          {
                              Id = 3,
                              Name = "Order3",
                              Items = new List<Item>()
                              {
                                  new Item()
                                  {
                                      Id = 31,
                                      Name = "Item 31",
                                      Price = 31
                                  },
                                  new Item()
                                  {
                                      Id = 32,
                                      Name = "Item 32",
                                      Price = 32
                                  },
                                  new Item()
                                  {
                                      Id = 33,
                                      Name = "Item 33",
                                      Price = 33
                                  }
                              }
                          }
                      };
}