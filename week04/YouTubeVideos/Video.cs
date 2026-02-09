using System;
using System.ComponentModel.DataAnnotations;

class Video
{
    public string _author;
    public string _title;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int GetCommentLength()
    {
        return _comments.Count();
    }

    public void GetComments()
    {
        foreach(Comment comment in _comments)
        {
            Console.Write($"    {comment._name} | ");
            Console.WriteLine(comment._comment);
        }
    }

    public void addComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Title: {_title}");
        Console.Write($"Duration: ");
        if (_length > 3600)
        {
            int hrs = _length / 3600;
            _length = _length % 3600;
            Console.Write($"{hrs}hrs ");
        }
        if (_length > 60)
        {
            int min = _length / 60;
            _length = _length % 60;
            Console.Write($"{min}min ");
            
        }
        Console.WriteLine($"{_length}s");
        Console.WriteLine();
        Console.WriteLine("Comments:");
        GetComments();
    }
}