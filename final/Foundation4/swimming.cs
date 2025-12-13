public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Each lap is 50 meters, convert to miles (1 mile = 1609.34 meters)
        return _laps * 50 / 1000.0 * 0.62; // Convert to km, then to miles
    }

    public override double GetSpeed()
    {
        // Speed = distance / time (in hours)
        return GetDistance() / (_minutes / 60.0);
    }

    public override double GetPace()
    {
        // Pace = time / distance (min per mile)
        return _minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutes} min) - Distance: {GetDistance():F2} miles, " +
               $"Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}
