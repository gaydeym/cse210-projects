public class BreathingActivity : Activity
{
    public void DisplayBreathing(int time)
    {
        while (time != 0)
        {
            int breatheTimeAssistant = 5;
            Console.WriteLine();
            Console.WriteLine("Breathe in...");

            while (breatheTimeAssistant != 0)
            {
                Console.Write(breatheTimeAssistant);
                Thread.Sleep(950);
                Console.Write("\b \b");

                breatheTimeAssistant -= 1;
                time -= 1;
            }

            breatheTimeAssistant = 5;
            Console.WriteLine("Now breathe out...");

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