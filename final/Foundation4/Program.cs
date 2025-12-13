class Program
{
    static void Main(string[] args)
    {
        // Create one object of each activity type
        Running running = new Running("03 Nov 2024", 30, 3.0);
        Cycling cycling = new Cycling("04 Nov 2024", 45, 15.0);
        Swimming swimming = new Swimming("05 Nov 2024", 35, 40);

        // Store all activities in a single list (polymorphism)
        List<Activity> activities = new List<Activity>
        {
            running,
            cycling,
            swimming
        };

        // Display header
        Console.WriteLine("=== FITNESS ACTIVITY TRACKER ===\n");
        Console.WriteLine("Activity Summaries:\n");

        // Iterate through the list and print summary for each activity
        // This demonstrates polymorphism - each activity type uses its own implementation
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        // Additional demonstration - showing individual calculations
        Console.WriteLine("\n" + new string('=', 70));
        Console.WriteLine("\nDetailed Breakdown:\n");

        foreach (Activity activity in activities)
        {
            string activityType = activity.GetType().Name;
            Console.WriteLine($"{activityType}:");
            Console.WriteLine($"  Distance: {activity.GetDistance():F2} miles");
            Console.WriteLine($"  Speed: {activity.GetSpeed():F2} mph");
            Console.WriteLine($"  Pace: {activity.GetPace():F2} min per mile");
            Console.WriteLine();
        }
    }
}