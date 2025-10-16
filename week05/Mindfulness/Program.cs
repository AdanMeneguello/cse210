using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "4" || string.IsNullOrWhiteSpace(choice))
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            Activity activity = null;

            if (choice == "1")
                activity = new BreathingActivity();
            else if (choice == "2")
                activity = new ListingActivity();
            else if (choice == "3")
                activity = new ReflectingActivity();
            else
                continue;

            Console.Write("Enter duration in seconds: ");
            int seconds;
            if (!int.TryParse(Console.ReadLine(), out seconds))
                seconds = 30;

            activity.SetDuration(seconds);

            if (activity is BreathingActivity breathing)
                breathing.Run();
            else if (activity is ListingActivity listing)
                listing.Run();
            else if (activity is ReflectingActivity reflecting)
                reflecting.Run();

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}
