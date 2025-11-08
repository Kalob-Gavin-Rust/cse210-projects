using System;
using System.Threading;

public class Activity
{
    private int _duration;
    private string _title;
    private string _description;

    // Constructor
    public Activity(string title, string description)
    {
        _title = title;
        _description = description;
        _duration = 0;
    }

    // Display standard start message
    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_title}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");

        if (int.TryParse(Console.ReadLine(), out int seconds))
        {
            _duration = seconds;
        }
        else
        {
            _duration = 10;
        }

        Console.WriteLine("Get ready to begin...");
        Spinner(3);
    }


    public void Spinner(int seconds)
    {
        string[] symbols = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(symbols[i % symbols.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
        Console.WriteLine();
    }

    // Countdown timer (used in breathing or listing)
    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    // Display standard ending message
    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Spinner(3);
        Console.WriteLine($"You have completed the {_title} for {_duration} seconds.");
        Spinner(3);
        Console.WriteLine();
    }

    // Getter for duration (used in subclasses)
    public int GetDuration()
    {
        return _duration;
    }
}
