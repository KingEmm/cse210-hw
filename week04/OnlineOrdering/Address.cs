

class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;
    public Address(string _streetAddress, string _city, string _state, string _country)
    {
        streetAddress = _streetAddress;
        city = _city;
        state = _state;
        country = _country;
    }
    public Address()
    {
        
    }

    public bool InTheUS()
    {
        if(country.ToLower() == "u.s.a" | country.ToLower() == "usa" | country.ToLower() == "united states" | country.ToLower() == "united states of america")
        {
            return true;
        }
        return false;
    }

    public string getFullAddress()
    {
        return $"   {streetAddress} {city}, \n   {state} {country}.";
    }
}