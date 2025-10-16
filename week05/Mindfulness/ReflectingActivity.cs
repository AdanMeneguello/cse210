using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you helped someone.",
        "Think of a time when you overcame a challenge.",
        "Think of a time when you made someone happy."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn from it?",
        "How did you feel during this experience?",
        "How can you apply this lesson in the future?"
    };

    public ReflectingActivity() 
        : base("Reflecting", "This activity helps you think about positive moments in your life.") 
    { }

    public void Run()
    {
        StartMessage();
        string prompt = GetRandomItem(_prompts);
        Console.WriteLine();
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Reflect on the following questions...");

        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        int i = 0;

        while (DateTime.Now < end)
        {
            string question = _questions[i % _questions.Count];
            Console.WriteLine($"> {question}");
            PauseWithSpinner(5);
            i++;
        }

        EndMessage();
    }
}
