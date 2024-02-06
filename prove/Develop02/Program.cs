using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        
        bool isRunning = true;

        while (isRunning)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    string prompt = generator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string entryText = Console.ReadLine();
                    Entry entry = new Entry
                    {
                        _date = DateTime.Now.ToShortDateString(),
                        _promptText = prompt,
                        _entryText = entryText
                    };
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("What is the filename?");
                    string fileToLoad = Console.ReadLine();
                    journal.LoadFromFile(fileToLoad);
                    break;
                case "4":
                    Console.WriteLine("What is the filename?");
                    string fileToSave = Console.ReadLine();
                    journal.SaveToFile(fileToSave);
                    break;
                case "5":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Exit");
        Console.Write("What would you like to do? ");
    }

}