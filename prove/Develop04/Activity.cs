public class Activity
{
    private string[] _description =
    {
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
    };

    public string _name { get; set; }
    public int _duration { get; set; }

    public void DisplayWelcome()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
    }

    public void DisplayDescription(int choice)
    {
        Console.WriteLine();
        Console.WriteLine(_description[choice - 1]);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like to run the activity? ");
    }

    public void DisplayAnimation(int time)
    {
        string[] animationFrames = { "|", "/", "-", "\\" };

        while (time != 0)
        {
            foreach (string frame in animationFrames)
            {
                Console.Write("\b \b");
                Console.Write(frame);
                Thread.Sleep(240);
            }
            time--;
        }
        Console.Write("\b \b");
    }

    public void GetReady()
    {
        Console.WriteLine("Get ready...");
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
