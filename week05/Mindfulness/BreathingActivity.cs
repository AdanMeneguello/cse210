using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by guiding you through slow breathing.") 
    { }

    public void Run()
    {
        StartMessage();
        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("Breathe in...");
            CountDown(4);
            Console.Write("Now breathe out...");
            CountDown(6);
            Console.WriteLine();
        }

        EndMessage();
    }

    private void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
