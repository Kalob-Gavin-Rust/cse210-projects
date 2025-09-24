using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        bool guess;
        string response;
        guess = false;
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("The Goal is to guess a number at random!");
        do
        {
            Console.WriteLine("What is your Guess?");
            response = Console.ReadLine();
            int x = int.Parse(response);
            if (x > number && x != number)
            {
                Console.WriteLine("Lower");
            }
            else if (x < number && x != number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                guess = true;
            }

        } while (guess == false);

        Console.WriteLine("You Guessed It");

    }
}