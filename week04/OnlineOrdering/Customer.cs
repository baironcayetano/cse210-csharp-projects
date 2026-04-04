class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }   

    public bool IsLocalCustomer()
    {
        return _address.IsInAmerica();
    }

    public string ShippingLabel()
    {
        return $"Name: {_name}\nTo: {_address.GetAddress()}";
    }
}