using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("=== Scripture Memorizer (Week 03) ===");
        Console.WriteLine("Press ENTER to hide more words, or type 'quit' to finish.\n");

        // Example scripture (multi-verse reference in the rubric)
        var reference = new Reference("Proverbs", 3, 5, 6);
        string text =
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
            "In all thy ways acknowledge him, and he shall direct thy paths.";

        // Create scripture
        var scripture = new Scripture(reference, text);
        Console.WriteLine(scripture.GetDisplayText());

        // Loop until all words are hidden or user quits
        while (true)
        {
            Console.Write("\n(ENTER = hide 3 words, 'quit' = stop) > ");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            // Hide a few words each step
            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine("=== Scripture Memorizer (Week 03) ===");
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Well done!");
                break;
            }
        }
    }
}
