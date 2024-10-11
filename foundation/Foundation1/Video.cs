
public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; } // in seconds
    private List<Comment> comments;

    public Video(string title, string author, int duration)
    {
        Title = title; 
        Author = author; 
        Duration = duration; 
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Duration: {Duration} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");

        foreach (Comment comment in comments)
        {
            comment.DisplayComment();
        }
    }
}
