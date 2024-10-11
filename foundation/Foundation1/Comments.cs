public class Comment
{
    public string _commentName = "";
    public string _commentText = "";

    public Comment( string commentName, string commentText)
    {
        commentName = _commentName;
        commentText = _commentText;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_commentName}: {_commentText}");
    }

}