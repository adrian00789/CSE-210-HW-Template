using System;
using System.Collections.Generic;
using System.Text;



public class Program
{
    static void Main(string[] args)
    {
        Product prod1 = new Product("Product1", "101", 20, 2);
        List<Product> products1 = new List<Product> { prod1 };

        Address addr1 = new Address("123 Street", "New York", "NY", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(products1, cust1);

        Product prod2 = new Product("Product2", "102", 25, 3);
        List<Product> products2 = new List<Product> { prod2 };

        Address addr2 = new Address("123 Street", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Jane Smith", addr2);
        Order order2 = new Order(products2, cust2);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Cost: " + order1.GetTotalCost() + "\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Cost: " + order2.GetTotalCost());
    }
}