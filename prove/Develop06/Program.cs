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
        
        int points;
        while (true)
        {
            Console.Write("Enter points for this goal: ");
            if (int.TryParse(Console.ReadLine(), out points))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for points.");
            }
        }
        
        Goal newGoal = null;
        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                Console.WriteLine("Simple goal created successfully!");
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                Console.WriteLine("Eternal goal created successfully!");
                break;
            case "3":
                int target;
                while (true)
                {
                    Console.Write("Enter target count for completion: ");
                    if (int.TryParse(Console.ReadLine(), out target))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for target count.");
                    }
                }
                
                int bonus;
                while (true)
                {
                    Console.Write("Enter bonus points for completing target: ");
                    if (int.TryParse(Console.ReadLine(), out bonus))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for bonus points.");
                    }
                }
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                Console.WriteLine("Checklist goal created successfully!");
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
        Console.Clear();
        Console.WriteLine("=== Record Event in a Goal ===");

        int goalCount = goalManager.GoalsCount;
        if (goalCount == 0)
        {
            Console.WriteLine("No goals found. Please add a goal first.");
            return;
        }
        goalManager.DisplayGoals();
        Console.Write("\nEnter the number of the goal to record an event: ");
        int goalIndex;
        if (!int.TryParse(Console.ReadLine(), out goalIndex) || goalIndex < 1 || goalIndex > goalCount)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }
        // Registrar el evento y actualizar la puntuación
        goalManager.RecordGoalEvent(goalIndex - 1);
        Console.WriteLine("Event recorded successfully!");
    }
    static void SaveGoals(GoalManager goalManager)
    {
        Console.Write("Enter the filename to save goals (e.g., goals.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(goalManager.Score);

            foreach (Goal goal in goalManager.GetGoals())
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals and score saved successfully.");
    }

    static void LoadGoals(GoalManager goalManager)
    {
        Console.Write("Enter the filename to load goals (e.g., goals.txt): ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                goalManager.ClearGoals();

                // Leer y establecer la puntuación
                int score;
                if (int.TryParse(reader.ReadLine(), out score))
                {
                    goalManager.SetScore(score);
                }
                else
                {
                    Console.WriteLine("Error reading score from file.");
                    return;
                }
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Goal goal = ParseGoalFromString(line);
                    if (goal != null)
                    {
                        goalManager.AddGoal(goal);
                    }
                    else
                    {
                        Console.WriteLine($"Failed to parse goal from line: {line}");
                    }
                }
            }

            Console.WriteLine("Goals and score loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals from file: {ex.Message}");
        }
    }

    static Goal ParseGoalFromString(string goalData)
    {
        try
        {
            string[] parts = goalData.Split('|');
            if (parts.Length < 4) // Verifica que hay suficientes partes
            {
                Console.WriteLine("Invalid goal data format.");
                return null;
            }

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points;

            if (!int.TryParse(parts[3], out points))
            {
                Console.WriteLine("Error parsing points.");
                return null;
            }

            switch (goalType)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(parts[4]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    if (isComplete)
                    {
                        simpleGoal.RecordEvent();
                    }
                    return simpleGoal;
                case "EternalGoal":
                    return new EternalGoal(name, description, points);
                case "ChecklistGoal":
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int i = 0; i < amountCompleted; i++)
                    {
                        checklistGoal.RecordEvent();
                    }
                    return checklistGoal;
                default:
                    Console.WriteLine("Unknown goal type found in file.");
                    return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error parsing goal data: {ex.Message}");
            return null;
        }
    }

}
