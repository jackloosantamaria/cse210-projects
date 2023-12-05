public class Running : Exercise{
    private double _distance;

    public Running(string date, int time, double distance):base(date, time){
        _name = "Running";
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;   
    }

    public override double Speed()
    {
        double velocity = _distance/_time * 60;
        double velocity2 = Math.Round(velocity,2);
        return velocity2;
    }

    public override double Pace()
    {
        double pace = _time/_distance;
        double pace2 = Math.Round(pace, 2);
        return pace2;
    }
}