// class Scripture
// {
//     private Reference reference;
//     private List<Word> words;
//     private Random random = new Random();
//     private List<Scripture> _scriptures;

//     public Scripture(Reference reference, string text)
//     {
//         this.reference = reference;
//         words = new List<Word>();

//         string[] wordArray = text.Split(' ');
//         foreach (string word in wordArray)
//         {
//             words.Add(new Word(word));
//         }
//     }

//     public void DisplayScripture()
//     {
//         Console.WriteLine(reference.GetDisplayText());
//         foreach (Word word in words)
//         {
//             Console.Write($"{word.GetDisplayText()} ");
//         }
//     }

//     public void HideRandomWords()
//     {
//         for (int i = 0; i < 3; i++) 
//         {
//             int index = random.Next(words.Count);
//             words[index].Hide();
//         }
//     }
//     public bool AllWordsHidden()
//     {
//         foreach (Word word in words)
//         {
//             if (!word.IsHidden())
//             {
//                 return false;
//             }
//         }
//         return true;
//     }
    
// }
using System;
using System.Collections.Generic;
using System.IO;

class Scripture
{
    private Reference reference;
    private List<Word> words;
    private Random random = new Random();

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }
    public void DisplayScripture()
    {
        Console.WriteLine(reference.GetDisplayText());
        foreach (Word word in words)
        {
            Console.Write($"{word.GetDisplayText()} ");
        }
        Console.WriteLine();
    }
    public void HideRandomWords()
    {
        for (int i = 0; i < 3; i++) 
        {
            int index = random.Next(words.Count);
            words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    // Método para cargar escrituras desde un archivo
    public static List<Scripture> LoadScripturesFromFile(string filename)
{
    List<Scripture> scriptures = new List<Scripture>();
    string[] lines = File.ReadAllLines(filename);

    Reference reference = null;
    string text = "";

    foreach (string line in lines)
    {
        if (line.StartsWith("Reference:"))
        {
            if (reference != null && !string.IsNullOrEmpty(text))
            {
                scriptures.Add(new Scripture(reference, text.Trim()));
            }

            string refText = line.Substring(10).Trim();
            reference = ParseReference(refText);  
            text = "";  
        }
        else if (line.StartsWith("Text:"))
        {
            text = line.Substring(5).Trim();  
        }
    }

    if (reference != null && !string.IsNullOrEmpty(text))
    {
        scriptures.Add(new Scripture(reference, text.Trim()));
    }

    return scriptures;
}

private static Reference ParseReference(string refText)
{
    // Example refText: "Proverbs 3:5-6"
    string[] parts = refText.Split(' '); 
    string book = parts[0];

    string[] chapterAndVerses = parts[1].Split(':'); 
    int chapter = int.Parse(chapterAndVerses[0]);

    string[] verses = chapterAndVerses[1].Split('-');
    int startVerse = int.Parse(verses[0]);
    int? endVerse = verses.Length > 1 ? int.Parse(verses[1]) : (int?)null;

    return new Reference(book, chapter, startVerse, endVerse);  
}

}
