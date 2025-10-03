using System;
using System.Globalization;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string response;
        int x;
        do
        {
            Console.WriteLine("Enter Number: ");
            response = Console.ReadLine();
            x = int.Parse(response);
            numbers.Add(x);
        } while (x != 0);
        Console.WriteLine(".............................");
        Console.WriteLine($"The Sum is: {numbers.Sum()}");
        Console.WriteLine($"The Average is:  {numbers.Average()}");
        Console.WriteLine($"The Maxium is: {numbers.Max()}");

    } 
} // I used ChatGPT to help me learn that I need 'System.Linq'-
// for the math portion to work.