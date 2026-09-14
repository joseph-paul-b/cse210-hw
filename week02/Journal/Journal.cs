using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is currently empty.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("===== Your Journal =====");
        Console.WriteLine();

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    $"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetMood()}|{entry.GetResponse()}"
                );
            }
        }

        Console.WriteLine($"Journal saved successfully to {filename}.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("That file could not be found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        List<Entry> loadedEntries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|', 4);

            if (parts.Length == 4)
            {
                Entry entry = new Entry(
                    parts[0],
                    parts[1],
                    parts[3],
                    parts[2]
                );

                loadedEntries.Add(entry);
            }
        }

        _entries = loadedEntries;

        Console.WriteLine($"Journal loaded successfully from {filename}.");
    }
}