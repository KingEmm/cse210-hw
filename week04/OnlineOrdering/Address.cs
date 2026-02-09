

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    public Address()
    {
        
    }

    public bool InTheUS()
    {
        if(_country.ToLower() == "u.s.a" | _country.ToLower() == "usa" | _country.ToLower() == "united states" | _country.ToLower() == "united states of america")
        {
            return true;
        }
        return false;
    }

    public string getFullAddress()
    {
        return $"   {_streetAddress} {_city}, \n   {_state} {_country}.";
    }
}