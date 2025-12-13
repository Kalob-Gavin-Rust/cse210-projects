public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string desc, string date, string time, string addr,
                           string weatherForecast)
        : base(title, desc, date, time, addr)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }
}