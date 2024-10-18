using System;

class Program
{
    static Dictionary<string, int> _activityLog=new Dictionary<string, int>()
        {
            {"Breathing Activity", 0},
            {"Reflection Activity", 0},
            {"Listing Activity", 0} 
        };
    static void Main(string[] args)
    {
        bool _keepRunning = true; 
        while (_keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Activity Program");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");  
            
            string _choice = Console.ReadLine();  
            switch (_choice)
            {
                case "1":
                    PerformBreathingActivity();
                    _activityLog["Breathing Activity"]++;
                    break;
                case "2":
                    PerformReflectionActivity();
                    _activityLog["Reflection Activity"]++;
                    break;
                case "3":
                    PerformListingActivity();
                    _activityLog["Listing Activity"]++;
                    break;
                case "4":
                    ShowFinalLog();
                    _keepRunning = false;  
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
    static void ShowFinalLog()
    {
        Console.WriteLine("\n--- Final Activity Log ---");
        Console.WriteLine($"Breathing Activity: {_activityLog["Breathing Activity"]} times");
        Console.WriteLine($"Reflection Activity: {_activityLog["Reflection Activity"]} times");
        Console.WriteLine($"Listing Activity: {_activityLog["Listing Activity"]} times");
        Console.WriteLine("--------------------------\n");
    }
    static void PerformBreathingActivity()
    {
        Console.Clear();
        Console.WriteLine("You've selected the Breathing Activity.");
        Console.WriteLine("Please enter the duration in seconds: ");
        int _duration = int.Parse(Console.ReadLine());

        BreathingActivity _myBreathingActivity = new BreathingActivity("Breathing Activity", 
            "This activity will help you relax by focusing on your breathing.");  
        _myBreathingActivity.SetDuration(_duration);
        _myBreathingActivity.StartActivity();
    }
    static void PerformReflectionActivity()
    {
        Console.Clear();
        Console.WriteLine("You've selected the Reflection Activity.");
        Console.Write("Please enter the duration in seconds: ");
        int _duration = int.Parse(Console.ReadLine());

        ReflectionActivity _myReflectionActivity = new ReflectionActivity("Reflection Activity", 
            "This activity will help you reflect on your strengths and resilience.");
        _myReflectionActivity.SetDuration(_duration);
        _myReflectionActivity.StartActivity();
    }
    static void PerformListingActivity()
    {
        Console.Clear();
        Console.WriteLine("You've selected the Listing Activity.");
        Console.Write("Please enter the duration in seconds: ");
        int _duration = int.Parse(Console.ReadLine());

        ListingActivity _myListingActivity = new ListingActivity("Listing Activity", 
            "This activity will help you list as many things as you can in a given area.");  
        _myListingActivity.SetDuration(_duration);
        _myListingActivity.StartActivity();
    }
}
