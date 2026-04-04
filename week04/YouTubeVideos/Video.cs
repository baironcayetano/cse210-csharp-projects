using System.Collections.Generic;

class Video{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int durationInSeconds){
        _title = title;
        _author = author;
        _length = durationInSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment){
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideo(){
        int hours = _length / (3600);
        int minutes = (_length % (3600)) / 60;
        int seconds = _length % 60;
        string duration = $"{hours:D2}:{minutes:D2}:{seconds:D2}";

        Console.WriteLine($"{_title}");
        Console.WriteLine($"Duration:{duration}");
        Console.WriteLine($"By: {_author}");
        Console.WriteLine($"Comments ({GetNumberOfComments()})");

        foreach(Comment comment in _comments){
            comment.DisplayComment();
        }
    }
}