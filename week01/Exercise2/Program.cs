using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");

        if (!int.TryParse(Console.ReadLine(), out int grade))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        string letter = GetLetterGrade(grade);
        string sign = GetGradeSign(grade, letter);

        Console.WriteLine($"Your letter grade is {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep trying and you'll do better next time.");
        }
    }

    static string GetLetterGrade(int grade)
    {
        switch (grade / 10)
        {
            case 10:
            case 9:
                return "A";
            case 8:
                return "B";
            case 7:
                return "C";
            case 6:
                return "D";
            default:
                return "F";
        }
    }

    static string GetGradeSign(int grade, string letter)
    {
        if (letter == "F")
        {
            return "";
        }

        int lastDigit = grade % 10;

        if (lastDigit >= 7 && letter != "A")
        {
            return "+";
        }
        else if (lastDigit < 3)
        {
            return "-";
        }

        return "";
    }
}