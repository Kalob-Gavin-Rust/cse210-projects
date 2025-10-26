using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart");

        while (true)
        {
            Console.Clear();
            scripture.GetText();   // display scripture text

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to end:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                scripture.GetText();
                Console.WriteLine("\nAll words hidden.");
                break;
            }
        }
    }
}
