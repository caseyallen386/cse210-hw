using System;
using System.Reflection;


public class Video
{


    private class Comment
    {
        private string _commentor;
        private string _text;

        public Comment(string name, string text)
        {
            _commentor = name;
            _text = text;
        }

        public string GetComment()
        {
            return $"{_commentor} - {_text}";
        }
    }


    private List<Comment> _comments = new List<Comment>();
    private string _title;
    private string _author;

    private int _lengthInSeconds;



    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public void AddComment(string name, string comment)
    {
        _comments.Add(
            new Comment(name, comment)
        );
    }

    public void Display()
    {
        Console.WriteLine($"Video Title: {_title} - Creator: {_author} - Video Duration: {_lengthInSeconds}sec");
        Console.WriteLine($"");
        
        Console.WriteLine($"Total Comments: {CountComments()}");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetComment());
        }

        

        Console.WriteLine("");
        Console.WriteLine("");
    }


}