public abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string title, string description, int points, bool isComplete)
    {
        _title = title;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public virtual void RecordEvent()
    {
        // Base does nothing
    }

    public virtual bool IsComplete()
    {
        return _isComplete;
    }

    public string GetTitle() => _title;
    public string GetDescription() => _description;
    public int GetPoints() => _points;
    public bool GetIsComplete() => _isComplete;

}
