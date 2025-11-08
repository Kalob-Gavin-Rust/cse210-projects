using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _rand;

    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _rand = new Random();
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        StartMessage();
        int duration = GetDuration();

        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine();
        Console.WriteLine($"List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        Countdown(3);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");
        EndMessage();
    }
}
