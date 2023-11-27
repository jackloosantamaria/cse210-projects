public class Customers{
    private string _name;
    private Address _fullAddress;

    public Customers(string name, Address fullAddress){
        _name = name;
        _fullAddress = fullAddress;
    }

    public bool IsUsa(){
        return _fullAddress.WithinUsa() ? true : false;
    }

    public string GetName(){
        return _name;
    }

    public string CreateAddress(){
        string createAddress = _fullAddress.CreateAddress();
        return createAddress;
    }
}