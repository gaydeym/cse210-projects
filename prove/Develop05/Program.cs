using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        List<string> motivationalMessages = new List<string>
        {
            "You are capable of amazing things!",
            "Every accomplishment starts with the decision to try.",
            "Believe you can and you're halfway there.",
            "The only way to do great work is to love what you do.",
            "You are stronger than you think.",
            "Success is not final, failure is not fatal: It is the courage to continue that counts."
        };

        Random random = new Random();
        int randomIndex = random.Next(0, motivationalMessages.Count);
        Console.WriteLine("Message of the day: " + motivationalMessages[randomIndex]);

        Thread.Sleep(2000);

        GoalManager goalManager = new GoalManager();
        bool run = true;

        while (run)
        {
            DisplayUserScore(goalManager);

            DisplayMenuOptions();

            ConsoleKey selectedKey = ReadValidMenuOption();

            switch (selectedKey)
            {
                case ConsoleKey.D1:
                    CreateNewGoal(goalManager);
                    break;
                case ConsoleKey.D2:
                    ListGoals(goalManager);
                    break;
                case ConsoleKey.D3:
                    SaveGoals(goalManager);
                    break;
                case ConsoleKey.D4:
                    LoadGoals(goalManager);
                    break;
                case ConsoleKey.D5:
                    RecordEvent(goalManager);
                    break;
                case ConsoleKey.D6:
                    RemoveGoal(goalManager);
                    break;
                case ConsoleKey.D7:
                    run = false;
                    Console.WriteLine("\nThank you for using the Eternal Quest Program. See you soon!");
                    break;
            }
        }
    }

    static void DisplayUserScore(GoalManager goalManager)
    {
        Console.WriteLine();
        Console.WriteLine($"You have {goalManager.UserScore()} points");
    }

    static void DisplayMenuOptions()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Remove Goal");
        Console.WriteLine(" 7. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    static ConsoleKey ReadValidMenuOption()
    {
        ConsoleKeyInfo keyInfo;
        ConsoleKey selectedKey;

        keyInfo = Console.ReadKey();
        selectedKey = keyInfo.Key;

        while (!(selectedKey >= ConsoleKey.D1 && selectedKey <= ConsoleKey.D7))
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Invalid Input. Choose From the menu options");
            DisplayMenuOptions();
            keyInfo = Console.ReadKey();
            selectedKey = keyInfo.Key;
        }

        return selectedKey;
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");

        Console.Write("Which type of goal would you like to create?: ");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        ConsoleKey selectedKey = keyInfo.Key;

        while (!(keyInfo.Key >= ConsoleKey.D1 && keyInfo.Key <= ConsoleKey.D3))
        {
            Console.WriteLine();
            Console.Write("Invalid input. Enter 1, 2 or 3  to continue ");
            keyInfo = Console.ReadKey();
            selectedKey = keyInfo.Key;
        }

        switch (selectedKey)
        {
            case ConsoleKey.D1:
                CreateSimpleGoal(goalManager);
                break;
            case ConsoleKey.D2:
                CreateEternalGoal(goalManager);
                break;
            case ConsoleKey.D3:
                CreateCheckListGoal(goalManager);
                break;
        }
    }

    static void CreateSimpleGoal(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is the description of your goal? ");
        string goalDescription = Console.ReadLine();

        Console.Write("How many points do you want associated with this goal? ");
        int goalPoint = int.Parse(Console.ReadLine());

        goalManager.AddGoals(new SimpleGoal(goalName, goalDescription, goalPoint));
    }

    static void CreateEternalGoal(GoalManager goalManager)
    {
        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is the description of your goal? ");
        string goalDescription = Console.ReadLine();

        Console.Write("How many points do you want associated with this goal? ");
        int goalPoint = int.Parse(Console.ReadLine());

        goalManager.AddGoals(new EternalGoal(goalName, goalDescription, goalPoint));
    }

    static void CreateCheckListGoal(GoalManager goalManager)
    {
        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is the description of your goal? ");
        string goalDescription = Console.ReadLine();

        Console.Write("How many points do you want associated with this goal? ");
        int goalPoint = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int targetCount = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());

        goalManager.AddGoals(new ChecklistGoal(goalName, goalDescription, goalPoint, bonus, targetCount));
    }

    static void ListGoals(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine();
        if (goalManager.LenOfGoalList() == 0)
        {
            Console.WriteLine();
            Console.WriteLine("There are no goals to List. Please add goals.");
            return;
        }
        goalManager.DisplayGoal();
    }

    static void SaveGoals(GoalManager goalManager)
    {
        Console.Clear();

        if (goalManager.LenOfGoalList() == 0)
        {
            Console.WriteLine();
            Console.WriteLine("There are no goals to save. Please add goals first.");
            return;
        }

        Console.WriteLine();
        Console.Write("Do you want to save to the default location? Enter y / n ");
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        while (keyInfo.KeyChar != 'n' && keyInfo.KeyChar != 'y')
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write("Invalid input. Enter 'n' or 'y' to continue ");
            keyInfo = Console.ReadKey();
        }

        if (keyInfo.KeyChar == 'n')
        {
            Console.WriteLine();
            Console.Write("Enter the name of the file you want to save to: ");
            string filePath = Console.ReadLine();
            goalManager.SaveGoalToFile(filePath);
            return;
        }
        goalManager.SaveGoalToFile();
    }

    static void LoadGoals(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine();
        Console.Write("Do you want to Load from the default location? Enter y / n ");
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        while (keyInfo.KeyChar != 'n' && keyInfo.KeyChar != 'y')
        {
            Console.WriteLine();
            Console.Write("Invalid input. Enter 'n' or 'y' to continue");
            keyInfo = Console.ReadKey();
        }

        if (keyInfo.KeyChar == 'n')
        {
            Console.WriteLine();
            Console.Write("Enter the name of the file you want to load from: ");
            string filePath = Console.ReadLine();
            goalManager.LoadGoalFromFile(filePath);
            return;
        }

        goalManager.LoadGoalFromFile();

        if (goalManager.LenOfGoalList() == 0)
        {
            Console.WriteLine();
            Console.WriteLine("There are no goals in the file.");
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine();
        if (goalManager.LenOfGoalList() == 0)
        {
            Console.WriteLine();
            Console.WriteLine("There are no goals to check in. Please add goals first.");
            return;
        }

        Console.Write("The incomplete goals are ");
        Console.WriteLine();

        goalManager.DisplayIncompleteGoals();

        Console.Write("Which goal did you accomplish?\n ");
        string goalIndexStr = Console.ReadLine();
        int goalIndex;

        while (!int.TryParse(goalIndexStr, out goalIndex) || goalIndex <= 0 || goalIndex > goalManager.LenOfGoalList())
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Enter a valid goal index to continue");
            Console.WriteLine();
            goalManager.DisplayGoal();
            goalIndexStr = Console.ReadLine();
        }

        Goal goalToRecord = goalManager.GoalToRecord(goalIndex);

        if (goalToRecord.IsComplete() && !(goalToRecord is EternalGoal))
        {
            Console.WriteLine("Sorry, this goal has been completed, and can not award any more points.");
        }
        else
        {
            goalManager.RecordGoalEvent(goalIndex);
            goalToRecord.RecordEventMsg();
            Console.WriteLine($"You now have {goalManager.UserScore()} points.");
        }
    }

    static void RemoveGoal(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine();
        if (goalManager.LenOfGoalList() == 0)
        {
            Console.WriteLine();
            Console.WriteLine("There are no goals to remove from. Please add or load goals first.");
            return;
        }

        Console.Write("What which goal do you want to remove? ");

        Console.WriteLine();
        goalManager.DisplayGoal();

        string goalIndexStr = Console.ReadLine();
        int goalIndex;

        while (!int.TryParse(goalIndexStr, out goalIndex) || goalIndex <= 0 || goalIndex > goalManager.LenOfGoalList())
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Enter a valid goal index to continue");
            goalManager.DisplayGoal();
            goalIndexStr = Console.ReadLine();
        }

        Console.Clear();
        goalManager.RemoveGoal(goalIndex);
        Console.WriteLine();
        Console.WriteLine("Goals left: ");
        goalManager.DisplayGoal();
    }
}
