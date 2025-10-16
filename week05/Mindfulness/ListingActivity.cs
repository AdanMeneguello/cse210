using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are you grateful for today?",
        "What made you smile recently?",
        "Who helped you this week?"
    };

    public ListingActivity() 
        : base("Listing", "This activity helps you reflect on good things in your life.") 
    { }

    public void Run()
    {
        StartMessage();
        string prompt = GetRandomItem(_prompts);
        Console.WriteLine();
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Start listing your thoughts... (press Enter after each one)");

        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        int count = 0;

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");
        EndMessage();
    }
}
