using System.Security.Cryptography.X509Certificates;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentname, string topic)
    {
        _studentName = studentname;
        _topic = topic;
    }

    public string GetName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}