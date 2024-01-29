using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        if (letter == "A" || letter == "B" || letter =="C")
        {
            Console.WriteLine($"Congratulations! You passed with a grade of {letter}.");
        }
        else
        {
            Console.WriteLine($"Sorry, you did not pass this time. Keep working hard for the next time!");
        }
        
    }
}