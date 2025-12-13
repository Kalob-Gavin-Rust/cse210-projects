public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // Distance = speed * time (in hours)
        return _speed * (_minutes / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // Pace = time / distance (min per mile)
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_minutes} min) - Distance: {GetDistance():F2} miles, " +
               $"Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}