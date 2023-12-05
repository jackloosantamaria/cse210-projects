using System.ComponentModel;

public class Exercise{
    protected string _date;
    protected int _time;
    protected string _name;

    public Exercise(string date, int time){
        _date = date;
        _time = time;
    }

    public virtual double Distance(){
        return 0;
    }

    public virtual double Speed(){
        return 0;
    }

    public virtual double Pace(){
        return 0;
    }

    public string GetSummary(){
        string word = $"{_date} {_name} ({_time} min) - Distance {Distance()} km, Speed: {Pace()} km/min";
        return word;
    }
}