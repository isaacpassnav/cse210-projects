public class  BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description):base(name,description)
    { 

    }
    public override void StartActivity()
    {
        ShowStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            Console.WriteLine("Inhale...");
            PauseWithCountdown(3);
            Console.WriteLine("Exhale...");
            PauseWithCountdown(3);
        }
        ShowEndMessage();
    }
    private void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}