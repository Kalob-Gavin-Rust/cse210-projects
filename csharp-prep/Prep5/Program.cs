using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome Here!");
        }
        static string PromptUserName()
        {
            Console.WriteLine("What is your Username:");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("Your Favorite Number as a int:");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int PromptUserBirthYear()
        {
            Console.WriteLine("The Year you were born:");
            int year = int.Parse(Console.ReadLine());
            return year;
        }
        static int SquareNumber(int x)
        {
            int y = x * x;
            return y;
        }
        static void DisplayResults(string userName, int y, int year)
        {
            Console.WriteLine($"{userName}, the square of your number is {y}");
            int age = 2025 - year;
            Console.WriteLine($"{userName}, you will turn {age} this year");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int x = PromptUserNumber();
        int year = PromptUserBirthYear();
        int y = SquareNumber(x);
        DisplayResults(userName, y, year);
        


    }
}