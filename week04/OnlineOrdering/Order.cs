

class Order
{
    private Customer customer;
    private List<Product> products; //= List<Product()>();


    public Order(){}
    public Order(Customer _customer, List<Product> _products)
    {
        customer = _customer;
        products = _products;
    }

    public float GetTotalPrice()
    {
        float total = 0;

        foreach(Product product in products)
        {
            total += product.GetTotalCost();
        }

        if (customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public void PackingLabel()
    {
        Console.WriteLine("Products:");
        foreach(Product product in products)
        {
            Console.WriteLine($"    {product.GetProductID()}: {product.GetName()}");
        }
        
    }
    public void ShippingLabel()
    {
        Console.WriteLine($"Name: {customer.GetName()}");
        Console.WriteLine("Address:");
        Console.WriteLine($"{customer.GetAddress()}");
        Console.WriteLine("-------------------------------------------------------------");
    }
}