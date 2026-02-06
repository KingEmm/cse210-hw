using System;
using System.ComponentModel.DataAnnotations;

class Video
{
    public string author;
    public string title;
    public int length;
    public List<Comment> comments = new List<Comment>();

    public int GetCommentLength()
    {
        return comments.Count();
    }

    public void GetComments()
    {
        foreach(Comment comment in comments)
        {
            Console.Write($"    {comment.name} | ");
            Console.WriteLine(comment.comment);
        }
    }

    public void addComment(Comment _comment)
    {
        comments.Add(_comment);
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Title: {title}");
        Console.Write($"Duration: ");
        if (length > 3600)
        {
            int hrs = length / 3600;
            length = length % 3600;
            Console.Write($"{hrs}hrs ");
        }
        if (length > 60)
        {
            int min = length / 60;
            length = length % 60;
            Console.Write($"{min}min ");
            
        }
        Console.WriteLine($"{length}s");
        Console.WriteLine();
        Console.WriteLine("Comments:");
        GetComments();
    }
}