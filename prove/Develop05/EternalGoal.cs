public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int point) : base(name, description, point)
    {
        GoalName = name;
        GoalDescription = description;
        GoalPoint = point;
    }
    
    public override bool IsComplete()
    {
        return false;
    }
    
    public override int RecordEvent()
    {
        BasePoint += GoalPoint;
        return BasePoint;
    }
    
    public override string GoalInfo()
    {
        return $"[ ] {GoalName} ({GoalDescription})";
    }
    
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GoalName}|{GoalDescription}|{GoalPoint}|{BasePoint}|{_uniqueId}";
    }
}