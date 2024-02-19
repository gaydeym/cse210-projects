public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _point;
    private int _basePoint;
    protected string _uniqueId;

    protected Goal(string name, string description, int point)
    {
        _goalName = name;
        _goalDescription = description;
        _point = point;
        _basePoint = 0;
        _uniqueId = Guid.NewGuid().ToString();
    }

    public string UniqueId
    {
        get => _uniqueId;
        set => _uniqueId = value;
    }
    
    protected string GoalName
    {
        get => _goalName;
        set => _goalName = value;
    }

    protected string GoalDescription
    {
        get => _goalDescription;
        set => _goalDescription = value;
    }

    protected int BasePoint
    {
        get => _basePoint;
        set => _basePoint = value;
    }

    protected int GoalPoint
    {
        get => _point;
        set => _point = value;
    }

    public int GetUserScore()
    {
        return _basePoint;
    }

    public string GetGoalName()
    {
        return _goalName;
    }
    
    public  void RecordEventMsg()
    {
        Console.WriteLine($"Congratulations! You have earned {_basePoint} points from Goal: '{_goalName}'");
    }
    
    public abstract int RecordEvent();
    public abstract string GetStringRepresentation();
    public abstract string GoalInfo();
    public abstract bool IsComplete();
}