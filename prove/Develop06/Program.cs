using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool keepRunning = true;
        
        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("=== Eternal Quest Program ===");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. View goals and progress");
            Console.WriteLine("3. Record an event in a goal");
            Console.WriteLine("4. View total score");
            Console.WriteLine("5. Save goals and score");
            Console.WriteLine("6. Load goals and score");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    RecordGoalEvent(goalManager);
                    break;
                case "4":
                    Console.WriteLine($"Total Score: {goalManager.Score}");
                    break;
                case "5":
                    SaveGoals(goalManager);
                    break;
                case "6":
                    LoadGoals(goalManager);
                    break;
                case "7":
                    keepRunning = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a number from 1 to 7.");
                    break;
            }
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine("=== Create a New Goal ===");
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");
        
        string choice = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;
        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter target count for completion: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing target: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type selected.");
                return;
        }
        if (newGoal != null)
        {
            goalManager.AddGoal(newGoal);
            Console.WriteLine("Goal added successfully!");
        }
    }
    static void RecordGoalEvent(GoalManager goalManager)
    {
        // Lógica para registrar un evento en una meta
    }
    static void SaveGoals(GoalManager goalManager)
    {
        // Lógica para guardar metas en un archivo
    }
    static void LoadGoals(GoalManager goalManager)
    {
        // Lógica para cargar metas desde un archivo
    }
}
