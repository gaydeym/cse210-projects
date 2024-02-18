public class ListingActivity : Activity
{
    private string[] _promptsQuestion = {"Who are people that you appreciate?",
                                "What are personal strengths of yours?",
                                "Who are people that you have helped this week?",
                                "When have you felt the Holy Ghost this month?",
                                "Who are some of your personal heroes"};
    private int _entryCount = 0;

    public void DisplayListing(int time)
    {
        var random = new Random();
        int index = random.Next(_promptsQuestion.Count());


        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        Console.WriteLine($"--- {_promptsQuestion[index]} ---\n");

        YouMayBegin();

        Write(time);

        DisplayMessageEnd();
    }

    private void YouMayBegin()
    {
        int time = 5;
        Console.Write("You may begin in:  ");

        while (time != 0)
        {
            Console.Write("\b");
            Console.Write(time);
            Thread.Sleep(1000);

            time -= 1;
        }

        Console.Write("\b \b");
        Console.WriteLine();
    }

    private void Write(int time)
    {
        _entryCount = 0;
        DateTime startTimeNow = DateTime.Now;
        DateTime endTimeFinish = startTimeNow.AddSeconds(time);
        DateTime currentTimeCurrent = DateTime.Now;

        while (currentTimeCurrent < endTimeFinish)
        {
            Console.Write("> ");
            Console.ReadLine();

            _entryCount += 1;
            currentTimeCurrent = DateTime.Now;
        }

        Console.WriteLine($"\nYou listed {_entryCount} items!");

    }
}