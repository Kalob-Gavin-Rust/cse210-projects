public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(int targetCount, int currentCount, int bonusPoints,
        string title, string description, int points, bool isComplete = false)
        : base(title, description, points, isComplete)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonusPoints = bonusPoints;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override void RecordEvent()
    {
        _currentCount++;

        if (_currentCount < _targetCount)
        {
            Console.WriteLine($"Great job! You earned {_points} points!");
            Console.WriteLine($"Progress: {_currentCount} / {_targetCount}");
        }
        else
        {
            _isComplete = true;

            int totalPoints = _points + _bonusPoints;

            Console.WriteLine($"GOAL COMPLETE!");
            Console.WriteLine($"You earned {_points} points + {_bonusPoints} bonus points = {totalPoints}!");
        }
    }
    public int GetCurrentCount() => _currentCount;
    public int GetTargetCount() => _targetCount;
    public int GetBonusPoints() => _bonusPoints;

}
