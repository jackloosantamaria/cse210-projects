public class Address{
    private string _country;
    private string _state;
    private string _city;
    private string _street;

    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool WithinUsa(){
        return _country == "USA" ? true : false;
    }

    public string CreateAddress(){
        string address = _street + ", " + _city + "\n" + _state + ", " + _country;
        return address;
    }
}