public class Orders{
    private Customers _client;
    private List<Products> _item;

    public Orders(List<Products> item, Customers client){
        _item = item;
        _client = client;
    }

    public double Shipping(){
        double cost = _client.IsUsa() ? 5:35;
        return cost;
    }

    public double TotalPrice(){
        double total=0;
        foreach(Products product in _item){
            double price = product.ShowPrice();
            total += price;
        }
        double cost = Shipping();
        total += cost;
        return total;
    }

    public string CreatePackageLabel(){
        string label = "Packing Label:\n";
        foreach (Products product in _item){
            label += product.GetName() + " - " + product.GetNumber() + "\n";
        }
        return label;
    }

    public string CreateShippingLabel(){
        string label = "Shipping Label:\n";
        label += _client.GetName() + "\n" + _client.CreateAddress();
        return label;
    }

    public string ShowTotalAmount(){
        string total = "\nProducts\n";
        double Price = TotalPrice();
        foreach(Products product in _item){
            total += product.GetName() + " (" + product.GetNumber() + ") -" + "$" + product.GetPrice() + " x " + product.GetAmount() + " = " + product.ShowPrice().ToString("0.00") + "\n";
        }
        total += "Shipping Cost: $" + Shipping().ToString("0.00") + "\n";
        total += "Total: $" + TotalPrice().ToString("0.00");
        return total;
    }

    public void ShowResults(){
        Console.WriteLine(CreatePackageLabel());
        Console.WriteLine(CreateShippingLabel());
        Console.WriteLine(ShowTotalAmount());


    }
}