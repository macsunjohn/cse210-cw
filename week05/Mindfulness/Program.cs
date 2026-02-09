// Exceeding requirements:
// This program tracks the total time spent across all mindfulness activities
// and displays the cumulative time when the user exits the program.

using System;

class Program
{
    static int totalTimeSpent = 0;

    static void Main()
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    totalTimeSpent += breathing.GetDuration();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    totalTimeSpent += reflecting.GetDuration();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    totalTimeSpent += listing.GetDuration();
                    break;
            }
        }

        Console.Clear();
        Console.WriteLine("Thank you for using the Mindfulness Program.");
        Console.WriteLine($"Total time spent in mindfulness activities: {totalTimeSpent} seconds.");
    }
}