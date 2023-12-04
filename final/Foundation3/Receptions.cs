public class Receptions:Event{
    private string _email;

    public Receptions(string name, string detail, string date, string time, Address address, string email): base(name, detail, date, time, address){
        _email = email;
    }

    public string GetEmail(){
        return _email;
    }

    public string EventType(){
        string type = "Reception";
        return type;
    }

    public string ReceiptionDetail(){
        string info = CreateEvent();
        info += "RSVP: " + _email;
        return info;
    }

    public string CreateEventReception(){
        string shortReception = "";
        string type = EventType();
        shortReception += "Event Type: " + type;
        shortReception += CreateShortEvent();
        return shortReception;
    }
}