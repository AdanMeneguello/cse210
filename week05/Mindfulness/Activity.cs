using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected Random random = new Random();

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} Activity ---");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed {_duration} seconds of the {_name} activity.");
        PauseWithSpinner(3);
    }

    protected void PauseWithSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            if (i >= spinner.Length)
            {
                i = 0;
            }
        }
    }

    protected string GetRandomItem(List<string> list)
    {
        int index = random.Next(list.Count);
        return list[index];
    }
}
