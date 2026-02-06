using System.Security.Cryptography.X509Certificates;

class Customer
{
    private string name;
    private Address address;
    public Customer(){}
    public Customer(string _name, Address _address)
    {
        name = _name;
        address = _address;
    }
    public bool LivesInUSA()
    {
        return address.InTheUS();
    }

    public string GetName()
    {
        return name;
    }
    public string GetAddress()
    {
        return address.getFullAddress();
    }
}