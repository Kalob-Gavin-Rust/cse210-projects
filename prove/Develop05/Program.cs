using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine($"\nTotal Score: {_totalPoints}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": CreateGoal(); break;
                case "2": DisplayGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveToFile(); break;
                case "5": LoadFromFile(); break;
                case "6": return;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Point Value: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(title, description, points, false));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(title, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("Target Count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus Points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(target, 0, bonus, title, description, points));
        }
    }

    private void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");

        int index = 1;
        foreach (Goal goal in _goals)
        {
            string status = goal.IsComplete() ? "[X]" : "[ ]";

            if (goal is ChecklistGoal cg)
            {
                Console.WriteLine($"{index}. {status} {cg.GetTitle()} ({cg.GetCurrentCount()}/{cg.GetTargetCount()})");
            }
            else
            {
                Console.WriteLine($"{index}. {status} {goal.GetTitle()}");
            }

            index++;
        }
    }

    private void RecordEvent()
    {
        DisplayGoals();

        Console.Write("\nWhich goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal.");
            return;
        }

        Goal selected = _goals[index];

        _totalPoints += selected.GetPoints();

        selected.RecordEvent();
    }

    private void SaveToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine(_totalPoints);

            foreach (Goal g in _goals)
            {
                if (g is SimpleGoal)
                {
                    sw.WriteLine($"Simple|{g.GetTitle()}|{g.GetDescription()}|{g.GetPoints()}|{g.GetIsComplete()}");
                }
                else if (g is EternalGoal)
                {
                    sw.WriteLine($"Eternal|{g.GetTitle()}|{g.GetDescription()}|{g.GetPoints()}");
                }
                else if (g is ChecklistGoal cg)
                {
                    sw.WriteLine($"Checklist|{cg.GetTitle()}|{cg.GetDescription()}|{cg.GetPoints()}|{cg.GetCurrentCount()}|{cg.GetTargetCount()}|{cg.GetBonusPoints()}");
                }
            }
        }

        Console.WriteLine("Goals saved!");
    }

    private void LoadFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        _totalPoints = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];

            if (type == "Simple")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (type == "Eternal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "Checklist")
            {
                _goals.Add(new ChecklistGoal(
                    int.Parse(parts[5]),
                    int.Parse(parts[4]),
                    int.Parse(parts[6]),
                    parts[1],
                    parts[2],
                    int.Parse(parts[3])
                ));
            }
        }

        Console.WriteLine("Goals loaded!");
    }
}
