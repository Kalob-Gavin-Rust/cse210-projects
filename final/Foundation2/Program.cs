using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer cust1 = new Customer("John Smith", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "LP100", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MS200", 25.50, 2));

        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");


        Address addr2 = new Address("44 King Street", "London", "London", "UK");
        Customer cust2 = new Customer("Emily Johnson", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Camera", "CM300", 450.00, 1));
        order2.AddProduct(new Product("Tripod", "TP500", 79.99, 1));

        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}\n");
    }
}