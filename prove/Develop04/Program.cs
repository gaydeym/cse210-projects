using System;

class Program
{
    static void Main(string[] args)
    {
        int[] activityCounts = { 0, 0, 0 };

        Console.Clear();

        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine($" 1. Start Breathing Activity ({activityCounts[0]})");
            Console.WriteLine($" 2. Start Reflecting Activity ({activityCounts[1]})");
            Console.WriteLine($" 3. Start Listing Activity ({activityCounts[2]})");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "4")
                break;

            if (!int.TryParse(choice, out int activityChoice) || activityChoice < 1 || activityChoice > 3)
            {
                Console.Clear();
                continue;
            }

            activityCounts[activityChoice - 1]++;

            Activity activity;

            switch (activityChoice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectingActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                default:
                    continue;
            }

            activity.DisplayWelcome();
            activity.DisplayDescription(activityChoice);

            if (int.TryParse(Console.ReadLine(), out int time))
            {
                activity._duration = time;
                Console.Clear();
                activity.GetReady();

                if (activity is BreathingActivity)
                    ((BreathingActivity)activity).DisplayBreathing(time);
                else if (activity is ReflectingActivity)
                    ((ReflectingActivity)activity).DisplayReflection(time);
                else if (activity is ListingActivity)
                    ((ListingActivity)activity).DisplayListing(time);
            }
        }

        Console.Clear();
        Console.WriteLine("Activity Counts:");
        Console.WriteLine($"Breathing Activity: {activityCounts[0]} times");
        Console.WriteLine($"Reflecting Activity: {activityCounts[1]} times");
        Console.WriteLine($"Listing Activity: {activityCounts[2]} times");
        Console.WriteLine();
        Console.WriteLine("Thanks for using the Activity app. Goodbye!");
    }
}