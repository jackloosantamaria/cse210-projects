using System.Globalization;

public class Products{
    private string _name;
    private string _number;
    private double _price;
    private int _amount;

    public Products(string name, string number, double price, int amount){
        _name = name;
        _number = number;
        _price = price;
        _amount = amount;
    }

    public double ShowPrice(){
        double numb = _price * _amount;
        double number = Math.Round(numb, 2);
        return number;
        
    }

    public string GetName(){
        return _name;
    }

    public string GetNumber(){
        return _number;
    }

    public double GetPrice(){
        return _price;
    }

    public int GetAmount(){
        return _amount;
    }


}