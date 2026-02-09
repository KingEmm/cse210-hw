

class Order
{
    private Customer _customer;
    private List<Product> _products; //= List<Product()>();


    public Order(){}
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public float GetTotalPrice()
    {
        float total = 0;

        foreach(Product product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_customer.LivesInUSA())
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
        foreach(Product product in _products)
        {
            Console.WriteLine($"    {product.GetProductID()}: {product.GetName()}");
        }
        
    }
    public void ShippingLabel()
    {
        Console.WriteLine($"Name: {_customer.GetName()}");
        Console.WriteLine("Address:");
        Console.WriteLine($"{_customer.GetAddress()}");
        Console.WriteLine("-------------------------------------------------------------");
    }
}