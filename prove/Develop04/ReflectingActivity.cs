public class ReflectingActivity : Activity
{
    private string[] _prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selflesst"
    };

    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };


    public void DisplayReflection(int time)
    {
        var randomQuestions = new Random();
        int index = randomQuestions.Next(_prompts.Count());

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {_prompts[index]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"> {_questions[index]}");

        DisplayAnimation(time);

        DisplayMessageEnd();
    }
}