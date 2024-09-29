public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now; // Automatically set the date to the current date
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()}: {Prompt} - {Response}";
    }
}
