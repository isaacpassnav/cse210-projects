class Program
{
    static List<Activity> activities = new List<Activity>();
    static void Main(string[] args)
    {
        activities.Add(new Running("03 Nov 2022", 30, 4.8, 70)); 
        activities.Add(new Cycling("03 Nov 2022", 45, 15.5, 70));
        activities.Add(new Swimming("03 Nov 2022", 20, 30, 70));

        DisplayActivityHistory();
    }
    static void DisplayActivityHistory()
    {
        Console.WriteLine("=== Activity History ===");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}


/*
Implementation of creative improvements in the physical activities program to demonstrate advanced object-oriented programming principles:

1. Activity History with Date and Time:
   - Added a `DateTime _timestamp` attribute in the `Activity` class to automatically store the exact date and time when each activity is created.
   - The `GetSummary()` method now includes the date and time to show a complete line with the detailed history of each activity.
   - In the `DisplayActivityHistory()` method within `Program`, the `activities` list is iterated to print a complete history with the dates and times of each activity.

2. Calculation of Calories Burned:
   - Added a `_weight` attribute in `Activity` to capture the user's weight in kilograms.
   - Added a `CalculateCaloriesBurned()` method in `Activity`, which is overridden in each derived activity to calculate calories according to the type of exercise.
       * **Running and Cycling**: Use `0.075 * weight * minutes`.
       * **Swimming**: Uses `0.1 * weight * minutes`.
   - Each summary (`GetSummary()`) now shows the estimated calories burned for the activity, considering the user's weight.
   - In `Program`, a weight value was added when creating activity instances to include this calorie calculation in each activity summary.

With these improvements, the program not only tracks and calculates detailed information on distance, speed, and pace, but also provides an estimate of calories burned to help users get a more comprehensive view of their progress.
*/

