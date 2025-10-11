using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    string journal = "journal.txt";

    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }

    public void LoadFromFile()
    {
        if (File.Exists(journal))
        {
            string[] lines = File.ReadAllLines(journal);
            _entries = new List<string>(lines);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void Menu()
    {
        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter your journal entry: ");
                string entry = Console.ReadLine();
                AddEntry(entry);
            }
            else if (choice == "2")
            {
                Display();
            }
            else if (choice == "3")
            {
                LoadFromFile();
            }
            else if (choice == "4")
            {
                SaveToFile(journal);
            }
        }
    }
}
