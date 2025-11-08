using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        StartMessage();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            Countdown(4);

            Console.Write("Now breathe out... ");
            Countdown(6);

            Console.WriteLine();
        }

        EndMessage();
    }
}
