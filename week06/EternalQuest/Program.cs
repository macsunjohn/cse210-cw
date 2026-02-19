//Creativity: The level-up system where by for every 1000 point earned, the use the user increases by 1 level
using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        //  CREATIVITY ADDED HERE (Styled Welcome Screen)
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("===================================================");
        Console.WriteLine("   Hello World! This is the EternalQuest Project   ");
        Console.WriteLine("===================================================");
        Console.ResetColor();

        Console.WriteLine("Track goals. Earn points. Level up.");
        Console.WriteLine();

        GoalManager manager = new GoalManager();
        manager.Start();

        Console.WriteLine("\nThanks for playing Eternal Quest!");
        Console.ReadKey();
    }
}
