using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }


        // Sum
        int sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine($"The sum is: {sum}");


        //Average
        float average = ((float)sum) / numbers.Count;
        
        Console.WriteLine($"The average is: {average}");


        //Largest Number
        int largestNumber = numbers[0];

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > largestNumber) 
            {
                largestNumber = numbers[i];
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");
        
    }
}