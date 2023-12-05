using System.ComponentModel;

public abstract class Exercise{
    protected string _date;
    protected int _time;
    protected string _name;

    public Exercise(string date, int time){
        _date = date;
        _time = time;
    }

     public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

    public string GetSummary(){
        return $"{_date} {_name} ({_time} min) - Distance {Distance()} km, Speed: {Speed()} kph, Pace: {Pace()} min per km";
        //return word;
    }
}