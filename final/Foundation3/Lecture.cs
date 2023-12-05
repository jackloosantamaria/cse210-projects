public class Lecture:Event{
    private string _lecturer;
    private int _capacity;

    public Lecture(string name, string detail, string date, string time, Address address, string lecturer, int capacity) : base(name, detail, date, time, address){
        _lecturer = lecturer;
        _capacity = capacity;
    }


    public string LectureDetail(){
        string word = CreateEvent();
        word += "Speaker: " + _lecturer;
        word += "\nCapacity: " + _capacity + " max.";
        return word;
    }

    public string CreateEventLecture(){
        string lectureEvent = "";
        string type = "Lecture";
        lectureEvent += "Event Type: " + type;
        lectureEvent += CreateShortEvent();
        return lectureEvent;
    }
}