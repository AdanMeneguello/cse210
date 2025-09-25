using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter output = new StreamWriter(filename))
            {
                foreach (Entry e in _entries)
                {
                    output.WriteLine(e.toFileLine());
                }
            }
            Console.WriteLine("Journal saved succesfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Could not save the journal. Error: {ex.Message}");
        }

    }

    public void LoadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(filename);

            _entries.Clear();

            foreach (string line in lines)
            {
                Entry e = Entry.FromFileLine(line);
                if (e != null)
                {
                    _entries.Add(e);
                }
            }

            Console.WriteLine("Journal loaded sucessfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Could not load the journal. Error: {ex.Message}");
        }
    }
    
}