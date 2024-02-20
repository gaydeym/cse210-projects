using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>{};
        
        Lecture lecture = new Lecture("Art Workshop", "Learn painting techniques", "3/10/2024", "15:00", "Art Center", "Emily Brown", 30);
        events.Add(lecture);

        Outdoor outdoor = new Outdoor("Community Cleanup", "Join us to clean the neighborhood", "4/22/2024", "09:00", "City Hall", "Volunteers needed");
        events.Add(outdoor);

        Reception reception = new Reception("Company Anniversary Party", "Celebrate 10 years of success", "6/15/2024", "19:00", "Grand Ballroom", "info@example.com");
        events.Add(reception);

        foreach (Event e in events)
        {
            Console.WriteLine(e.FullDetails());
            Console.WriteLine();
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(e.ShortDescription());
            Console.WriteLine();
        }
    }
}
