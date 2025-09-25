using System;

class Program
{
    static void Main(string[] args)
    {
        promptGenerator promptGenerator = new promptGenerator();
        Journal journal = new Journal();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("=== Jornal Menu ===");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the jornal");
            Console.WriteLine("3. Load from file");
            Console.WriteLine("4. Save to file");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("Choose an option(1-5):");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._prompt = prompt;
                newEntry._text = response;

                journal.AddEntry(newEntry);
                Console.WriteLine("Entry added.");
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to load (e.g., journal.txt): ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);

            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter filename to save (e.g., journal.txt): ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thanks, bye!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please choose a valid option (1-5).");
            }
        }
    }
}