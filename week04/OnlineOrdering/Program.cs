using System;

class Program
{
    static void Main(string[] args)
    {
    //     new Product(1001, "Wireless Mouse", 24.99),
    // new Product(1002, "Mechanical Keyboard", 79.95m, 3),
    // new Product(1003, "USB-C Cable", 12.50, 3),
    // new Product(1004, "27-inch Monitor", 189.99m, 1)

        Customer johnB = new Customer(
            "John T. Baptist",
            "10200 S Temple Dr",
            "South Jordan", 
            "UT",
            "USA" 
        );


        Order order1 = new Order(johnB);

        Order order2  = new Order(johnB);

        
        order1.AddOrderItem(new Product(1001, "Wireless Mouse", 24.99m, 1));
        order1.AddOrderItem(new Product(1003, "USB-C Cable", 12.50m, 3));

        order2.AddOrderItem(new Product(1002, "Mechanical Keyboard", 79.95m, 1));
        order2.AddOrderItem(new Product(1004, "27-inch Monitor", 189.99m, 1));


        order1.PrintShippingLabel();
        
        order1.PrintPackingLabel();
        
        order1.DisplayTotal();
        
        Console.WriteLine("\n\n");
        
        order2.PrintShippingLabel();
        order2.PrintPackingLabel();
        order2.DisplayTotal();

    }
}