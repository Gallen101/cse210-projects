using System;
using System.IO.Compression;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _journal= new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _journal.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach ( Entry entry in _journal)
        {
            entry.display();
            Console.WriteLine();
        }

    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _journal)
            {
                outputFile.WriteLine($"{entry._time} | {entry._prompt} | {entry._entry}");
            }
            outputFile.Flush();
        }
        Console.WriteLine("Journal Saved!");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("Error: File not found.");
            return;
        }
        _journal.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts.Length == 3)
            {
                Entry loadedEntry = new Entry();
                loadedEntry._time = parts[0];
                loadedEntry._prompt = parts[1];
                loadedEntry._entry = parts[2];
                _journal.Add(loadedEntry);
            }
        }
        Console.WriteLine("Journal Loaded!");
    }
}