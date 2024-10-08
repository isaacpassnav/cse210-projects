using System;
using System.Collections.Generic;
// class Program
// {
//     static void Main(string[] args)
//     {
//          // Sample scripture
//         Reference reference = new Reference("Proverbs", 3, 5, 6);
//         Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
        
//         // Main loop
//         while (!scripture.AllWordsHidden())
//         {
//             Console.Clear();
//             scripture.DisplayScripture();
            
//             Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
//             string input = Console.ReadLine();
            
//             if (input.ToLower() == "quit")
//                 break;

//             scripture.HideRandomWords();
//         }
//     }
// }
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = Scripture.LoadScripturesFromFile("scriptures.txt");
        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        do
        {
            Console.Clear();
            selectedScripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            selectedScripture.HideRandomWords();

        } while (!selectedScripture.AllWordsHidden());

        Console.WriteLine("All words are hidden. Program has ended.");
    }
}

// Exceeding Requirements: 
// 1. Added a library of scriptures that are chosen randomly.
// 2. Implemented loading of scriptures from a file.
// 3. Introduced a hint system to assist with memorization challenges.

