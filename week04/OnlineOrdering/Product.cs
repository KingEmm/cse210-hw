

class Product
{
    private string name;
    private int productID;
    private float price;
    private int quantity;
    public Product(){}
    public Product(string _name, int _productID, float _price, int _quantity)
    {
        name = _name;
        productID = _productID;
        price = _price;
        quantity = _quantity;
    }

    public float GetTotalCost()
    {
        return price * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public int GetProductID()
    {
        return productID;
    }

}