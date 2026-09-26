using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - Customer in the USA
        Address address1 = new Address(
            "123 Main Street",
            "Provo",
            "Utah",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        Order order1 = new Order(customer1);

        Product product1 = new Product(
            "Laptop",
            "P1001",
            850.00,
            1
        );

        Product product2 = new Product(
            "Wireless Mouse",
            "P1002",
            25.00,
            2
        );

        Product product3 = new Product(
            "Keyboard",
            "P1003",
            45.00,
            1
        );

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Order 2 - Customer outside the USA
        Address address2 = new Address(
            "15 Allen Avenue",
            "Ikeja",
            "Lagos",
            "Nigeria"
        );

        Customer customer2 = new Customer(
            "Joseph Paul",
            address2
        );

        Order order2 = new Order(customer2);

        Product product4 = new Product(
            "Headphones",
            "P2001",
            75.00,
            1
        );

        Product product5 = new Product(
            "USB Cable",
            "P2002",
            10.00,
            3
        );

        Product product6 = new Product(
            "Webcam",
            "P2003",
            60.00,
            1
        );

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // Display Order 1
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine();

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine();
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}
