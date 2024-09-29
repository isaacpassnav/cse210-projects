// using System;
// using System.IO;
// class Program
// { //Entry Class
//     public class Entry
//     {
//         public string Prompt { get; set; }
//         public string Response { get; set; }
//         public DateTime Date { get; set; }

//         public Entry(string prompt, string response)
//         {
//             Prompt = prompt;
//             Response = response;
//             Date = DateTime.Now;
//         }
//         public override string ToString()
//         {
//             return $"{Date.ToShortDateString()}: {Prompt} - {Response}";
//         }
//     }

//     public class Journal
//     {
//         private List<Entry> _entries = new List<Entry>();

//         public void AddEntry(Entry entry)
//         {
//             _entries.Add(entry);
//         }

//         public void DisplayEntries()
//         {
//             foreach (var entry in _entries)
//             {
//                 Console.WriteLine(entry.ToString());
//             }
//         }

//         // Save journal to a file using StreamWriter
//         public void SaveToFile(string filename)
//         {
//             using (StreamWriter writer = new StreamWriter(filename))
//             {
//                 foreach (var entry in _entries)
//                 {
//                     // Format the data with a comma separator for easy reading later
//                     writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
//                 }
//             }
//             Console.WriteLine($"Journal saved to {filename}");
//         }

//         // Load journal from a file
//         public void LoadFromFile(string filename)
//         {
//             // Clear current entries to replace with the loaded ones
//             _entries.Clear();
//             string[] lines = File.ReadAllLines(filename);

//             foreach (string line in lines)
//             {
//                 string[] parts = line.Split(',');

//                 if (parts.Length == 3)
//                 {
//                     // Create a new Entry object and add it to the journal
//                     DateTime date = DateTime.Parse(parts[0]);
//                     string prompt = parts[1];
//                     string response = parts[2];

//                     _entries.Add(new Entry(prompt, response) { Date = date });
//                 }
//             }
//             Console.WriteLine($"Journal loaded from {filename}");
//         }
//     }

//     static void Main(string[] args)
//     {
//         Journal journal = new Journal();
//         string[] prompts = 
//         {
//             "Who was the most interesting person I interacted with today?",
//             "What was the best part of my day?",
//             "How did I see the hand of the Lord in my life today?",
//             "What was the strongest emotion I felt today?",
//             "If I had one thing I could do over today, what would it be?"
//         };

//         bool running = true;
//         while (running)
//         {
//             Console.WriteLine("\nMenu:");
//             Console.WriteLine("1. Write a new entry");
//             Console.WriteLine("2. Display the journal");
//             Console.WriteLine("3. Save the journal to a file");
//             Console.WriteLine("4. Load the journal from a file");
//             Console.WriteLine("5. Quit");
//             Console.Write("Choose an option: ");
//             string choice = Console.ReadLine();

//             switch (choice)
//             {
//                 case "1":
//                     Random rand = new Random();
//                     string prompt = prompts[rand.Next(prompts.Length)];
//                     Console.WriteLine(prompt);
//                     string response = Console.ReadLine();
//                     journal.AddEntry(new Entry(prompt, response));
//                     break;
//                 case "2":
//                     journal.DisplayEntries();
//                     break;
//                 case "3":
//                     Console.Write("Enter a filename to save: ");
//                     string saveFile = Console.ReadLine();
//                     journal.SaveToFile(saveFile);
//                     break;
//                 case "4":
//                     Console.Write("Enter a filename to load: ");
//                     string loadFile = Console.ReadLine();
//                     journal.LoadFromFile(loadFile);
//                     break;
//                 case "5":
//                     running = false;
//                     break;
//                 default:
//                     Console.WriteLine("Invalid option, please try again.");
//                     break;
//             }
//         }
//     }
   
// }


