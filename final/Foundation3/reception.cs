public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string desc, string date, string time, string addr,
                     string rsvpEmail)
        : base(title, desc, date, time, addr)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}