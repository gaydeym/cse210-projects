using System;

class Program
{
    static void Main(string[] args)
    {
        string keep = "yes";
        
        while (keep == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int attempts = 1;
            
            while (magicNumber != guess)
            {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
                attempts++;
            } 
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
                attempts++;
            }
            else {
                Console.WriteLine($"You guessed it! You have made {attempts} attempts!");
                
                Console.Write("Do want to play again? ");
                keep = Console.ReadLine();
                
                if (keep == "yes")
                {
                    keep = "yes";
                }
                else
                {
                    keep = "no";
                    Console.WriteLine("Good game!");
                }
            }
            }
        }
    }
}