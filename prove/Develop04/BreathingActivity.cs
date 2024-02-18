public class BreathingActivity : Activity
{
    private string _breatheOut = "NowBreathe Out...";
    private string _breatheIn = "Breathe In...";

    public void DisplayBreathing(int time)
    {

        int breatheTimeAssistant = 5;

        while (time != 0)
        {
            breatheTimeAssistant = 5;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(_breatheIn);

            while (breatheTimeAssistant != 0)
            {
                Console.Write(breatheTimeAssistant);
                Thread.Sleep(950);
                Console.Write("\b \b");

                breatheTimeAssistant -= 1;

                time -= 1;
            }

            breatheTimeAssistant = 5;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(_breatheOut);

            while (breatheTimeAssistant != 0)
            {
                Console.Write(breatheTimeAssistant);
                Thread.Sleep(950);
                Console.Write("\b \b");

                breatheTimeAssistant -= 1;

                time -= 1;
            }
        }
        DisplayMessageEnd();
    }
}