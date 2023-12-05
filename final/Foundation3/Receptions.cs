public class Receptions:Event{
    private string _email;

    public Receptions(string name, string detail, string date, string time, Address address, string email): base(name, detail, date, time, address){
        _email = email;
    }


    public string ReceiptionDetail(){
        string info = CreateEvent();
        info += "RSVP: " + _email;
        return info;
    }

    public string CreateEventReception(){
        string shortReception = "";
        string type = "Reception";
        shortReception += "Event Type: " + type;
        shortReception += CreateShortEvent();
        return shortReception;
    }
}