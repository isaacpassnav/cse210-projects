using System.IO;
public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    // Save journal to a file using StreamWriter
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                // Format the data with a comma separator for easy reading later
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    // Load journal from a file
    public void LoadFromFile(string filename)
    {
        // Clear current entries to replace with the loaded ones
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            if (parts.Length == 3)
            {
                // Create a new Entry object and add it to the journal
                DateTime date = DateTime.Parse(parts[0]);
                string prompt = parts[1];
                string response = parts[2];

                _entries.Add(new Entry(prompt, response) { Date = date });
            }
        }
        Console.WriteLine($"Journal loaded from {filename}");
    }
}