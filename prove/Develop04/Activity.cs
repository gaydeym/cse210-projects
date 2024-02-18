public class Activity
{
    private string[] _descriptions =
    {
        "This activity will help you relax by walking your through \nbreathing in and out slowly. Clear your mind and focus on your breathing.  \n \nHow long, in seconds (10, 20, 30, etc.), would you like to run the activity? ",
        "This activity will help you reflect on times in your life when you have shown \nstrength and resilience. This will help you recognize the power you have and \nhow you can use it in other aspects of your life. \n \nHow long, in seconds (10, 20, 30, etc.), would you like to run the activity? ",
        "This activity will help you reflect on the good things in your life by having \nyou list as many things as you can in a certain area. \n \nHow long, in seconds (10, 20, 30, etc.), would you like to run the activity?",
    };

    public string activity { private get; set; }
    public int Time { get; set; }

    public void DisplayWelcome()
    {
        Console.Clear();
        Console.WriteLine($"Hello Welcome to the {activity} enjoy.");
    }

    public void DisplayDescription(int choice)
    {
        Console.WriteLine(_descriptions[choice - 1]);
    }

    public void DisplayAnimation(int _time)
    {
        while (_time != 0)
        {
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(240);

            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(240);

            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(240);

            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(240);

            _time -= 1;
        }
        Console.Write("\b \b");
    }
    public void GetReady()
    {
        Console.WriteLine("\n Ready...");
        DisplayAnimation(3);
    }
    public void DisplayMessageEnd()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}