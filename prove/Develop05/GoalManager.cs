public class GoalManager
{
    private List<Goal> _goalList = new ();
    
    
    public int LenOfGoalList()
    {
        return _goalList.Count;
    }
    
    public void AddGoals(Goal goal)
    {
        _goalList.Add(goal);
    }

    public void DisplayGoal()
    {
        for (int i = 0; i < _goalList.Count; i++)
        {
            Goal goal = _goalList[i];
            Console.WriteLine($"{i + 1}. {goal.GoalInfo()}");
        }
    }

    public void DisplayIncompleteGoals()
    {
        for (int i = 0; i < _goalList.Count; i++)
        {
            Goal goal = _goalList[i];
            if ((goal is SimpleGoal || goal is ChecklistGoal) && !goal.IsComplete() || goal is EternalGoal)
            {
                Console.WriteLine($"    {i + 1}. {goal.GetGoalName()}");
            }
        }
    }

    public int UserScore()
    {
        int score = 0;
        foreach (Goal goal in _goalList)
        {
           score += goal.GetUserScore();
        }
        return score;
    }

    public void RecordGoalEvent(int goalIndex)
    {
        GoalToRecord(goalIndex).RecordEvent();
    }
    
    public Goal GoalToRecord(int goalIndex)
    {
        Goal goalToRecord = _goalList[goalIndex - 1];

        return goalToRecord;
    }

    public void RemoveGoal(int goalIndex)
    {
        Goal removedGoal = _goalList[goalIndex - 1];
        _goalList.Remove(removedGoal);

        if (removedGoal is SimpleGoal)
        {
            Console.WriteLine($"You have successfully removed a Simple Goal: '{removedGoal.GetGoalName()}'");
        }

        else if (removedGoal is ChecklistGoal)
        {
            Console.WriteLine($"You have successfully removed a Checklist Goal: '{removedGoal.GetGoalName()}'");
        }

        else if (removedGoal is EternalGoal)
        {
            Console.WriteLine($"You have successfully removed an Eternal Goal: '{removedGoal.GetGoalName()}'");
        }
    }
    
    public void SaveGoalToFile(string filePath="goal")
    {
        if (Path.HasExtension(filePath) && Path.GetExtension(filePath) != ".txt"  || !Path.HasExtension(filePath))
        {
            filePath = Path.ChangeExtension(filePath, ".txt");
        }

        StreamWriter writer = new StreamWriter(filePath);
        using (writer)
        {
            foreach (Goal goal in _goalList)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }


    public void LoadGoalFromFile(string filePath="goal")
    {
        if (Path.HasExtension(filePath) && Path.GetExtension(filePath) != ".txt" || !Path.HasExtension(filePath))
        {
            filePath = Path.ChangeExtension(filePath, ".txt");
        }

        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string goalInfo = parts[1];
            
            Goal goal = CreateGoal(goalType, goalInfo);

            if (!IsContainGoal(goal))
            {
                _goalList.Add(goal);
            }
        }
    }
    
    private bool IsContainGoal(Goal goal)
    {
        foreach (Goal g in _goalList)
        {
            if(g.UniqueId == goal.UniqueId)
            {
                return true;
            }
        }
        return false;
    }
    
    private Goal CreateGoal(string goalType, string goalInfo)
    {
        switch (goalType)
        {
            case "SimpleGoal":
            {
                string[] parts = goalInfo.Split("|");

                string name = parts[0];
                string description = parts[1];
                int point = int.Parse(parts[2]);
                bool isCompleted = bool.Parse(parts[3]);
                string uniqueId = parts[4];
                
                Goal simpleGoal = new SimpleGoal(name, description, point);
                
                simpleGoal.UniqueId = uniqueId;
                
                if (isCompleted)
                {
                    simpleGoal.RecordEvent();
                }
                
                return simpleGoal;
            }

            case "CheckListGoal":
            {
                string[] parts = goalInfo.Split("|");
            
                string name = parts[0];
                string description = parts[1];
                int point = int.Parse(parts[2]);
                int bonus = int.Parse(parts[3]);
                int currentCount = int.Parse(parts[4]);
                int targetCount = int.Parse(parts[5]);
                string uniqueId = parts[6];

                Goal checkListGoal = new ChecklistGoal(name, description, point, bonus, targetCount);
                checkListGoal.UniqueId = uniqueId;
                
                for (int i = 0; i < currentCount; i++)
                {
                    checkListGoal.RecordEvent();
                }
                
                return checkListGoal;
            }

            case "EternalGoal":
            {
                string[] parts = goalInfo.Split("|");

                string name = parts[0];
                string description = parts[1];
                int point = int.Parse(parts[2]);
                int basePoint = int.Parse(parts[3]);
                string uniqueId = parts[4];

                Goal eternalGoal = new EternalGoal(name, description, point);
                eternalGoal.UniqueId = uniqueId;
                
                for (int i = 0; i < basePoint / point; i++)
                {
                    eternalGoal.RecordEvent();
                }

                return eternalGoal;
            }
            
            default:
                return null;
        }
    }
}