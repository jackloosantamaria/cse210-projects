public class Gathering:Event{
    private string _climate;

    public Gathering(string name, string detail, string date, string time, Address address, string climate):base(name, detail, date, time, address){
        _climate = climate;
    }

    public string GetWeather(){
        return _climate;
    }

    public string CreateReport(){
        string word = "The weather will be ";
        return word + _climate;
    }

    public string EventType(){
        string info2 = "Outdoor Gathering";
        return info2;
    }

    public string GatheringDetail(){
        string data = "";
        string weatherInfo = CreateReport();
        data += CreateEvent();
        data += "Weather Statement: " + weatherInfo;
        return data;
    }

    public string CreateEventGathering(){
        string shortGathering = "";
        string type = EventType();
        shortGathering += "Event Type: " + type;
        shortGathering += CreateShortEvent();
        return shortGathering;
    }
}