public class Event{
    private string _name;
    private string _detail;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string name, string detail, string date, string time, Address address){
        _name = name;
        _detail = detail;
        _date = date;
        _time = time;
        _address = address;
    }

    public string CreateEvent(){
        string show = "Title: " + _name + "\n";
        show += "Description: " + _detail + "\n";
        show += "Date: " + _date + " " + _time + "\n";

        string address =  _address.CreateAddress();
        show += address + "\n";
        return show;
    }

    public string CreateShortEvent(){
        string shortEvent = "\nTitle: " + _name + "\n";
        shortEvent += _date;
        return shortEvent;
    }


}