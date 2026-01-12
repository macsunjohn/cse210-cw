using System;

class Program
{
    static void Main(string[] args)

    {
        // Ask for the magic number
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        // Ask for the user's guess
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        // Determine the result
        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }

}
