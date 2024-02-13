using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Random random = new Random();

        bool run = true;

        while (run)
        {
            Scripture scripture = library.GetRandomScripture(random);

            Console.WriteLine($"{scripture.Reference.GetDisplayText()} | {scripture.GetDisplayText()}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }

            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                int numberOfWordsToHide = random.Next(1, scripture.NumberOfVisibleWords() + 1);
                scripture.HideRandomWords(numberOfWordsToHide);
                Console.WriteLine($"{scripture.Reference.GetDisplayText()} | {scripture.GetDisplayText()}");
                Console.WriteLine("");
                Console.WriteLine("Press enter to continue or type 'quit' to exit.");
                input = Console.ReadLine();
                if (input == "quit")
                {
                    break;
                } 
            }

            run = false;
        }
    }
}