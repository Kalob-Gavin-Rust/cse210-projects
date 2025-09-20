using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Grade.");
        string x = Console.ReadLine();
        int number = int.Parse(x);
        if (number >= 90)
        {
            Console.WriteLine("Your Grade is an, A");
        }
        else if (number <= 89 && number >= 80)
        {
            Console.WriteLine("Your Grade is a, B");
        }
        else if (number <= 79 && number >= 70)
        {
            Console.WriteLine("Your Grade is a, C");
        }
        else if (number <= 69 && number >= 60)
        {
            Console.WriteLine("Your Grade is a, D");
        }
        else 
        {
            Console.WriteLine("You Failed the Class, F");
        }
    }
}