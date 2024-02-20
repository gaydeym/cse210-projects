using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>{};

        Video cookingTutorial = new Video("How to Cook Pasta", "Chef Gordon Ramsay", 600);
        cookingTutorial.AddComment("Sarah", "This recipe changed my life!");
        cookingTutorial.AddComment("John", "I burned my pasta following this, 0/10");
        cookingTutorial.AddComment("Alice", "Can't wait to try this out for dinner tonight!");
        _videos.Add(cookingTutorial);

        Video travelVlog = new Video("Exploring Tokyo", "Traveler Wanderlust", 1200);
        travelVlog.AddComment("David", "Tokyo is definitely on my bucket list!");
        travelVlog.AddComment("Emily", "I miss Japan so much!");
        travelVlog.AddComment("Michael", "Great video, thanks for sharing your adventure!");
        _videos.Add(travelVlog);

        Video codingTutorial = new Video("Learn Python in 30 Minutes", "Code Master", 1800);
        codingTutorial.AddComment("Sophia", "Very helpful tutorial, thank you!");
        codingTutorial.AddComment("Daniel", "I finally understand loops now, thanks!");
        codingTutorial.AddComment("Olivia", "Can you make a tutorial on web development next?");
        _videos.Add(codingTutorial);

        foreach (Video video in _videos)
        {
            Console.WriteLine();
            video.Display();
            Console.WriteLine();
        }
    }
}