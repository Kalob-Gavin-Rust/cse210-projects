class Program
{
    static void Main(string[] args)
    {

        Lecture lecture = new Lecture(
            "Understanding AI and Machine Learning",
            "A comprehensive introduction to artificial intelligence concepts",
            "March 15, 2024",
            "2:00 PM",
            "123 Tech Lane, San Francisco, CA",
            "Dr. Sarah Johnson",
            100
        );

        Reception reception = new Reception(
            "Annual Company Gala",
            "Join us for an evening of celebration and networking",
            "April 20, 2024",
            "7:00 PM",
            "456 Party Ave, New York, NY",
            "rsvp@company.com"
        );

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Spring Picnic Festival",
            "Family-friendly outdoor event with games and food",
            "May 5, 2024",
            "11:00 AM",
            "789 Park Road, Austin, TX",
            "Sunny, 75°F"
        );

        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        Console.WriteLine("=== EVENT PLANNING SYSTEM ===\n");

        foreach (Event evt in events)
        {
            Console.WriteLine(new string('=', 60));
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine("\n" + new string('-', 60));
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine("\n" + new string('-', 60));
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine(new string('=', 60));
            Console.WriteLine();
        }

        Console.WriteLine("\n=== MARKETING MATERIALS ===\n");
        Console.WriteLine("Short Descriptions for Social Media:\n");
        foreach (Event evt in events)
        {
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine();
        }
    }
}