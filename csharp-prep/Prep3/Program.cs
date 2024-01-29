using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int tries = 1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
                tries++;
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
                tries++;
            }
            else
            {
                Console.WriteLine($"You guessed it! {tries} attempts");
            }

        }
    }
}