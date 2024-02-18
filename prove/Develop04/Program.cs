using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        Console.Clear();

        while (choice != "4")
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();
            int activityInt = Int32.Parse(choice);

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();

                breathingActivity.activity = "Breathing Activity";
                breathingActivity.DisplayWelcome();
                breathingActivity.DisplayDescription(activityInt);

                breathingActivity.Time = Int32.Parse(Console.ReadLine());

                breathingActivity.GetReady();
                breathingActivity.DisplayBreathing(breathingActivity.Time);
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();

                reflectingActivity.activity = "Reflecting Activity";
                reflectingActivity.DisplayWelcome();
                reflectingActivity.DisplayDescription(activityInt);

                reflectingActivity.Time = Int32.Parse(Console.ReadLine());

                reflectingActivity.GetReady();
                reflectingActivity.DisplayReflection(reflectingActivity.Time);
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();

                listingActivity.activity = "Listing Activity";
                listingActivity.DisplayWelcome();
                listingActivity.DisplayDescription(activityInt);

                listingActivity.Time = Int32.Parse(Console.ReadLine());

                listingActivity.GetReady();
                listingActivity.DisplayListing(listingActivity.Time);
            }
        }

        Console.Clear();
        Console.WriteLine("Thanks for using the Activity app. Goodbye!");
    }
}