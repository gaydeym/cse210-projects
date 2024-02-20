using System;

public class Comment
{
    private string _author = "";
    private string _content = "";

    public Comment(string author, string text)
    {
        _author = author;
        _content = text;
    }

    public void Display()
    {
        Console.WriteLine(_author);
        Console.WriteLine(_content);
    }
}