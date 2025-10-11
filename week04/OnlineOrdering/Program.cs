using System;
class Program
{
    static void Main(string[] args)
    {
        // ===== Order #1 (USA) =====
        var addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        var cust1 = new Customer("Allison Rose", addr1);
        var order1 = new Order(cust1);

        order1.AddProduct(new Product("USB-C Cable", "C001", 8.99, 2));
        order1.AddProduct(new Product("Wireless Mouse", "M010", 19.50, 1));

        // ===== Order #2 (International) =====
        var addr2 = new Address("Av. Paulista 1000", "São Paulo", "SP", "Brazil");
        var cust2 = new Customer("Adan Meneguello", addr2);
        var order2 = new Order(cust2);

        order2.AddProduct(new Product("Notebook", "N777", 4.25, 5));
        order2.AddProduct(new Product("Mechanical Keyboard", "K333", 59.90, 1));

        // display order
        PrintOrder("Order #1", order1);
        Console.WriteLine(new string('-', 40));
        PrintOrder("Order #2", order2);
    }

    static void PrintOrder(string title, Order order)
    {
        Console.WriteLine(title);
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total: ${order.CalculateTotalCost():0.00}");
    }
}
