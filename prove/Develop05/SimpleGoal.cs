public class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points, bool isComplete = false)
        : base(title, description, points, isComplete)
    {
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
}
