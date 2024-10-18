public class BaseActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public BaseActivity( string name, string description)
    {
        this._name = name;
        this._description = description;
    }
    public void SetDuration(int duration)
    {
        this._duration = duration;
    }
    protected void ShowStartMessage()
    {
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.WriteLine("Please get ready...");
        PauseWithAnimation(3);
    }
    protected void ShowEndMessage()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        PauseWithAnimation(3);
    }
    protected void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i<seconds; i++)
        {
            Console.Write("|");
        Thread.Sleep(500); 
        Console.Write("\b/");
        Thread.Sleep(500); 
        Console.Write("\b-");
        Thread.Sleep(500); 
        Console.Write("\b\\");
        Thread.Sleep(500);
        }
        Console.WriteLine();
    }
    public virtual void StartActivity()
    {
        Console.WriteLine("Starting base activity...");
    }
}