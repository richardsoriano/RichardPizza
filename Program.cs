using RichardPizza.Data;
using RichardPizza.Models;

namespace RichardPizza;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Richard's Pizza!");
        using RichardPizzaContext context = new RichardPizzaContext();

        OrderDetail orderdetail1 = new OrderDetail()
        {
            Id = 1,
            Quantity = 100,
            ProductId = 1,
            OrderId = 1,
        };
       // context.OrderDetails.Add(orderdetail1);
        OrderDetail orderdetail2 = new OrderDetail()
        {
            Id = 2,
            Quantity = 200,
            ProductId = 2,
            OrderId = 2,
        };
        //context.OrderDetails.Add(orderdetail2);
        //context.SaveChanges();
        //Order
        //Order order1 = new Order()
        //{
        //    Id = 1,
        //    OrderPlaced = DateTime.Now,
        //    OrderFulfilled = DateTime.Now,
        //    CustomerId = 2
        //};
        //context.Orders.Add(order1);

        //Order order2 = new Order()
        //{
        //    Id = 2,
        //    OrderPlaced = DateTime.Now,
        //    OrderFulfilled = DateTime.Now,
        //    CustomerId = 1
        //};
        //context.Orders.Add(order2);
        //Customer customer2 = new Customer()
        //{
        //    Id=2,
        //    FirstName = "Holly",
        //    LastName="Soriano",
        //    Address="123 Main St",
        //    Phone="111-111-1111",
        //    Email="richard@abc.com",

        //};
        //context.Customers.Add(customer2);
        //Customer customer3 = new Customer()
        //{
        //    Id = 3,
        //    FirstName = "Dave",
        //    LastName = "Gilmore",
        //    Address = "123 Main St",
        //    Phone = "111-111-1111",
        //    Email = "richard@abc.com",

        //};
        //context.Customers.Add(customer3);
        //Customer customer4 = new Customer()
        //{
        //    Id = 4,
        //    FirstName = "Hodor",
        //    LastName = "Hogwards",
        //    Address = "123 Main St",
        //    Phone = "111-111-1111",
        //    Email = "richard@abc.com",

        //};
        //context.Customers.Add(customer4);
        //Customer customer5 = new Customer()
        //{
        //    Id = 5,
        //    FirstName = "J K ",
        //    LastName = "Rowling",
        //    Address = "666 Main St",
        //    Phone = "111-111-1111",
        //    Email = "richard@abc.com",

        //};
        //context.Customers.Add(customer5);  
        //context.SaveChanges();


        var products = context.Products;
        //.OrderBy(p => p.OrderDetails);
        Console.WriteLine(new String('-', 20));
        Console.WriteLine("Products");
        foreach (Product p in products)
        {
            Console.WriteLine($"Id: {p.Id}");
            Console.WriteLine($"Name: {p.Name}");
            Console.WriteLine($"Price: {p.Price}");

            Console.WriteLine(new String('-', 20));
        }
        var orderdetails = context.OrderDetails;
        //.OrderBy(p => p.OrderDetails);
        Console.WriteLine("Orders");
        Console.WriteLine(new String('-', 20));
        foreach (OrderDetail od in orderdetails)
        {
            Console.WriteLine($"Id: {od.Id}");
            Console.WriteLine($"Quantity: {od.Quantity}");
            Console.WriteLine($"ProductId: {od.ProductId}");
            Console.WriteLine($"OrderId: {od.OrderId}");
            Console.WriteLine(new String('-', 20));
        }
    }
}
