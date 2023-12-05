public class StationaryBicycles:Exercise{
    private double _speed;

    public StationaryBicycles(string date, int time, double speed):base(date, time){
        _name = "Stationary Bicycles";
        _speed = speed;
    }

    public override double Distance()
    {
        double distance = _speed * _time / 60;
        double distance2 = Math.Round(distance, 2);
        return distance2;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        double pace = 60 / _speed;
        double pace2 = Math.Round(pace,2);
        return pace2;
    }
}