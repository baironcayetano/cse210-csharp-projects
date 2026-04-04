using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        List<Product> products = new List<Product>
        {
            new Product("T-shirt","RamdonId21232", 16.99, 2),
            new Product("Samsung Smart Tv","Tv12a2gasf", 749.99, 1),
            new Product("Apple Iphone 17", "appl3121312",999.99,1),
            new Product("Nike Shoes", "nike1a2dav12", 86.49, 1),
            new Product("Addidas Shoes","addidas1ac13a", 78.99, 1),
            new Product("Generic sockets", "sa1233123", 12.99, 4),
            new Product("Jean", "jean1aasdasd1", 40.00, 2),
        };

        List<Address> addresses = new List<Address>
        {
            new Address("123 Main St", "San Diego", "CA", "USA"),
            new Address("456 Elm St", "New York City", "NY", "USA"),
            new Address("789 Oak St", "Austin", "TX", "USA"),
            new Address("321 Maple St", "Toronto", "ON", "Canada"),
            new Address("1231 Calle Libertador 4ave", "Mexico City", "DF", "Mexico"),
            new Address("987 Cedar St", "Miami", "FL", "USA"),
            new Address("Col. Monterrey", "Tegucigalpa","FM", "Honduras"),
        };

        List<string> customerNames = new List<string>
        {
            "Carlos Sanchez",
            "Marta Garcia",
            "Nathan Lee",
            "Spenser Burton",
            "Ana Martinez",
            "Johan Smith",
        };

        Random random = new Random();
        for (int i = 0; i < 4; i++)
        {
            int randomIndex = random.Next(0, customerNames.Count);
            Customer customer = new Customer(customerNames[randomIndex], addresses[randomIndex]);
            Order order = new Order(customer);
            orders.Add(order);
        }

        foreach(Order order in orders){
           int randomNumberOfItems = random.Next(3, products.Count);
           for (int i = 0; i < randomNumberOfItems; i++)
           {
                int randomIndex = random.Next(0, products.Count); 
                order.AddProduct(products[randomIndex]);
           }
        }

        //Printing orders
        foreach(Order order in orders)
        {
            Console.WriteLine("\n====================================");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine($"Packing Label: {order.PackingLabel()}");
            Console.WriteLine($"Total: ${order.Total()}");
        }

        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
}