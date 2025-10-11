using System.Collections.Generic;

public class Video
{
    // private fields (encapsulation)
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    // add one comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // number of comments (used by Program to display)
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // simple getters used only for display in Program
    public string GetTitle() => _title;
    public string GetAuthor() => _author;
    public int GetLengthInSeconds() => _lengthInSeconds;

    // expose a read-only view for iteration
    public List<Comment> GetComments() => _comments;
}
