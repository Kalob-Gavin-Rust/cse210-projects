using System;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5, 1);
        Fraction f3 = new Fraction(3, 4);

        f1.GetTop();
        f1.GetBottom();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        f2.GetTop();
        f2.GetBottom();
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        f3.GetTop();
        f3.GetBottom();
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    
        
    }
}