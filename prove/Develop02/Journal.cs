using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
 

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            //Console.WriteLine(entry);
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))

        {
            foreach (Entry entry in _entries)
            {
                string entryline = $"{entry._date}~{entry._prompt}~{entry._response}";
                outputFile.WriteLine(entryline);
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~");

                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                Entry entry = new Entry(DateTime.Parse(date), prompt, response);

                AddEntry(entry);
            }
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
                PromptGenerator prompt = new PromptGenerator();
                string promptGiven = prompt.Generate();
                Console.WriteLine(promptGiven);
                string entry = Console.ReadLine();
                DateTime date = DateTime.Now;
                Entry entry1 = new Entry(date, promptGiven, entry);

                AddEntry(entry1);
            }
            else if (choice == "2")
            {
                Display();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter Filename: ");
                string fileName = Console.ReadLine();
                LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter Filename: ");
                string fileName = Console.ReadLine();
                SaveToFile(fileName);
            }
        }
    }
}
