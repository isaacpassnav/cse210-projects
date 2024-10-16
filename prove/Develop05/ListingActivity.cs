public class ListingActivity : BaseActivity
{
    private List<string> _prompts;
    private List<string> _userResponses;

    public ListingActivity(string name, string description):base(name,description)
    {
        this._prompts = new List<string>()
        {
            "Who are the people you appreciate?",
            "What are your personal strengths?",
            "Who have you helped this week?",
            "When have you felt the Spirit this month?",
            "Who are some of your personal heroes?"
        };
        this._userResponses = new List<string>();
    }
    public override void StartActivity()
    {
        ShowStartMessage();

        Random random = new Random();
        string reflectionPrompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {reflectionPrompt}");
        PauseWithAnimation(3);

        Console.WriteLine("You have a few seconds to think about the prompt...");
        PauseWithAnimation(5);

        Console.WriteLine("Start listing items now:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            Console.Write("Enter an Item: ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                _userResponses.Add(response);
            }
            else
            {
                Console.WriteLine("Empty input, please enter something.");
            }
        }
        Console.WriteLine($"You listed {_userResponses.Count} items.");
        ShowEndMessage();
    }
}  