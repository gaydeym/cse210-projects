public class ReflectingActivity : Activity
{
    private string[] _promptsQuestion =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selflesst",
        "Think of a time when you felt happy"
    };

    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
    };

    public void DisplayReflection(int time)
    {
        var randomQuestions = new Random();
        int index = randomQuestions.Next(_promptsQuestion.Count());

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {_promptsQuestion[index]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"> {_questions[index]}");

        DisplayAnimation(time);

        DisplayMessageEnd();
    }
}