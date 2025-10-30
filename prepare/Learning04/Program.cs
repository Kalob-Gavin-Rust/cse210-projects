using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Kalob Rust", "Fractions");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();
        MathAssignment a2 = new MathAssignment("Kalob Rust", "Math", "8", "9-10");
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();
        WritingAssignment a3 = new WritingAssignment("Erin Rust", "Mountains", "Moving Mountains");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInfo());

    }
}