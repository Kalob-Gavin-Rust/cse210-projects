using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Minecraft Ep1", "Rust", 60);
        Video video2 = new Video("C#, Why I suck at it", "Rust", 5);
        Video video3 = new Video("Get off the computer", "Erin", 3);

        Comment comment1 = new Comment("Kalob", "Coolbeans");
        Comment comment2 = new Comment("Alice", "Great post!");
        Comment comment3 = new Comment("Bob", "I agree!");
        Comment comment4 = new Comment("Charlie", "Nice one!");
        Comment comment5 = new Comment("Dana", "Very informative!");
        Comment comment6 = new Comment("Eve", "Thanks for sharing!");

        video1.AddComment(comment1);
        video1.AddComment(comment2);

        video2.AddComment(comment3);
        video2.AddComment(comment4);

        video3.AddComment(comment5);
        video3.AddComment(comment6);

        Console.WriteLine("Minecraft Ep1 Video Info");
        Console.WriteLine($"Video Author: {video1.GetAuthor}");
        Console.WriteLine($"Video Length: {video1.GetLength()}");
        Console.WriteLine($"Comment Count: {video1.GetCommentCount()}");
        video1.GetComments();
        Console.WriteLine();
        Console.WriteLine("C#, Why I suck at it");
        Console.WriteLine($"Video Author: {video2.GetAuthor}");
        Console.WriteLine($"Video Length: {video2.GetLength()}");
        Console.WriteLine($"Comment Count: {video2.GetCommentCount()}");
        video2.GetComments();
        Console.WriteLine();
        Console.WriteLine("Get off the computer");
        Console.WriteLine($"Video Author: {video3.GetAuthor}");
        Console.WriteLine($"Video Length: {video3.GetLength()}");
        Console.WriteLine($"Comment Count: {video3.GetCommentCount()}");
        video3.GetComments();

    }
}