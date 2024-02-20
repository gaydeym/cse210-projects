using System;

public class Video
{
    private string _title = "";
    private string _author = "";
    private int _length = 0;
    private List<Comment> _comments = new List<Comment> {};

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string author, string text)
    {
        Comment comment = new Comment(author, text);
        _comments.Add(comment);
    }
    
    public void Display()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_author}: {_length} seconds");
        Console.WriteLine();
        Console.WriteLine("Comments: ");
        Console.WriteLine();
        foreach (Comment comment in _comments)
        {
            comment.Display();
            Console.WriteLine();
        }
    }
}