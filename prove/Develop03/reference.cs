class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int? endVerse;

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        if (endVerse.HasValue)
        {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }
        else
        {
            return $"{book} {chapter}:{startVerse}";
        }
    }
}