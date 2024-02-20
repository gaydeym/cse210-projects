using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>{};
        
        Running run = new Running("01 Feb 2024", 5.2, 0.5);
        exercises.Add(run);

        Swimming swim = new Swimming("02 Feb 2024", 20.5, 25);
        exercises.Add(swim);

        Cycling cycle = new Cycling("03 Feb 2024", 15.3, 8);
        exercises.Add(cycle);

        foreach (Exercise e in exercises)
        {
            Console.WriteLine(e.Summary());
        }
    }
}
