using System;
using System.Collections.Generic;

public class Journal
{
    private List<JournalEntry> _entries; // Intentional error: forgot to initialize the list

    public Journal()
    {
        // Error: missing initialization of _entries
    }

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry); // Will throw a NullReferenceException
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries) // Error: might throw an exception if _entries is null
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename)) // Error: Missing 'using System.IO;'
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear(); // Error: might throw exception if _entries is null
        using (StreamReader reader = new StreamReader(filename)) // Error: Missing 'using System.IO;'
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|'); // Error: separator hardcoded and might mismatch
                JournalEntry entry = new JournalEntry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }
    }
}