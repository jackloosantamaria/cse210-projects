public class Gathering:Event{
    private string _climate;

    public Gathering(string name, string detail, string date, string time, Address address, string climate):base(name, detail, date, time, address){
        _climate = climate;
    }

    public string GatheringDetail(){
        string data = "";
        string weatherInfo = "The weather will be ";
        data += CreateEvent();
        data += "Weather Statement: " + weatherInfo + " " + _climate;
        return data;
    }

    public string CreateEventGathering(){
        string shortGathering = "";
        string type = "Outdoor Gathering";
        shortGathering += "Event Type: " + type;
        shortGathering += CreateShortEvent();
        return shortGathering;
    }
}