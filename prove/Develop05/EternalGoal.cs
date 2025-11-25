public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points, bool isComplete = false)
        : base (title, description, points, isComplete)
    {
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You earned {_points} points!");
    }
}