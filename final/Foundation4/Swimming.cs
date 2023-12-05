using System.ComponentModel;

public class Swimming:Exercise{
    private double _completion;

    public Swimming(string date, int time, double completion):base(date, time){
        _name = "Swimming";
        _completion = completion;
    }

    public override double Distance()
    {
        double distance = _completion * 50 / 1000;
        return distance;
    }

    public override double Speed()
    {
        double speed = Distance() / _time * 60;
        double speed2 = Math.Round(speed,2);
        return speed2;
    }

    public override double Pace()
    {
        double pace = _time / Distance();
        return pace;
    }
}