public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string title, string desc, string date, string time, string address)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Standard Details:\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }

    public virtual string GetShortDescription()
    {
        string eventType = this.GetType().Name;
        return $"Short Description:\nType: {eventType}\nTitle: {_title}\nDate: {_date}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
}