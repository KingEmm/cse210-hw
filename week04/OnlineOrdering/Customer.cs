using System.Security.Cryptography.X509Certificates;

class Customer
{
    private string _name;
    private Address _address;
    public Customer(){}
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool LivesInUSA()
    {
        return _address.InTheUS();
    }

    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.getFullAddress();
    }
}