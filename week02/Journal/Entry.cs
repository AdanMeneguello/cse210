using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _text;

    public void Display()
    {
        Console.WriteLine($"-------------------");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_text}");
        Console.WriteLine($"-------------------");
    }

    public string toFileLine()
    {
        string safeText = _text?.Replace("\r", " ").Replace("\n", " ");
        string safePrompt = _prompt?.Replace("\r", " ").Replace("\n", " ");
        return $"{_date} | {safeText}";
    }

    public static Entry FromFileLine(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length != 3) return null;

        Entry e = new Entry();
        e._date = parts[0];
        e._prompt = parts[1];
        e._text = parts[2];
        return e;
    }
}
