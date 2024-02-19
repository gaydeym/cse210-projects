public class ChecklistGoal : Goal
{
    private int _currentCount;
    private int _targetCount;
    private int _bonus;
    private int _count;
    
    public ChecklistGoal(string name, string description, int point, int bonus, int targetCount) : base(name, description, point)
    {
        GoalName = name;
        GoalDescription = description;
        GoalPoint = point;
        _bonus = bonus;
        _currentCount = 0;
        _targetCount = targetCount;
        _count = 0;
    }
    
    public override bool IsComplete()
    {
        return _currentCount == _targetCount;
    }

    private int IsCompleteCount()
    {
        if (IsComplete())
        {
            return ++_count;
        }
        return _count;
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            BasePoint += GoalPoint;
            _currentCount++;
        }

        if (IsCompleteCount() == 1)
        {
            BasePoint += _bonus;
        }

        return BasePoint;

    }
  
    public override string GoalInfo()
    {
        if(IsComplete()) return $"[X] {GoalName} ({GoalDescription})";

        return $"[ ] {GoalName} ({GoalDescription}) --- Currently " +
               $"Completed: {_currentCount}/{_targetCount}";
    
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{GoalName}|{GoalDescription}|{GoalPoint}|{_bonus}|{_currentCount}|{_targetCount}|{_uniqueId}";
    }

}