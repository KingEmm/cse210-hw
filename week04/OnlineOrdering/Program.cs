using System;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer("James Brown", new Address("1st Avenue", "Manchester", "New York", "USA"));
        Customer cus2 = new Customer("James Jones", new Address("2nd Avenue", "Manchester", "Ohio", "USA"));
        Customer cus3 = new Customer("Jones James", new Address("St Brady street", "New City", "Ontario", "Canada"));

        Product HpProBook = new Product("HP Pro Book", 1, 699, 1);
        Product MacBook = new Product("Mac Book", 2, 1499, 1);
        Product KeyBoard = new Product("Key Board", 3, 199, 1);

        Order order = new Order(cus1, new List<Product>([HpProBook, MacBook]));
        Order order2 = new Order(cus2, new List<Product>([KeyBoard, MacBook]));
        Order order3 = new Order(cus3, new List<Product>([KeyBoard, MacBook, HpProBook]));

        order.PackingLabel();
        Console.WriteLine($"Total: {order.GetTotalPrice()}");
        order.ShippingLabel();

        order3.PackingLabel();
        Console.WriteLine($"Total: {order2.GetTotalPrice()}");
        order3.ShippingLabel();

        order2.PackingLabel();
        Console.WriteLine($"Total: {order3.GetTotalPrice()}");
        order2.ShippingLabel();
    }
}