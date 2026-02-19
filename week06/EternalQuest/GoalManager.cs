using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    // ⭐ CREATIVITY ADDED HERE (Level System)
    private int GetLevel()
    {
        return (_score / 1000) + 1;
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine($"⭐ Current Level: {GetLevel()}"); // ⭐ Creativity

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: RecordEvent(); break;
                case 4: SaveGoals(); break;
                case 5: LoadGoals(); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
            _goals.Add(new SimpleGoal(name, description, points));

        else if (type == 2)
            _goals.Add(new EternalGoal(name, description, points));

        else if (type == 3)
        {
            Console.Write("Target times: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int oldLevel = GetLevel();

        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points!");

        int newLevel = GetLevel();

        // Creativity added at this point ( The Level Up Message)
        if (newLevel > oldLevel)
        {
            Console.WriteLine("🎉 LEVEL UP!");
            Console.WriteLine($"You are now Level {newLevel}!");
        }
    }

    private void SaveGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal")
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));

            else if (parts[0] == "EternalGoal")
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));

            else if (parts[0] == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(parts[1], parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]),
                    int.Parse(parts[5])));
        }
    }
}
