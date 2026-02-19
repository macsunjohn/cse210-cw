using System;

public class EternalGoal : Goal
{
    // ⭐ CREATIVITY ADDED HERE
    private int _timesCompleted = 0;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        _timesCompleted++;

        // Creativity added at this point
        Console.WriteLine($"You have completed this goal {_timesCompleted} times!");

        return _points;
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[∞] {_shortName} ({_description}) -- Completed {_timesCompleted} times";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}|{_timesCompleted}";
    }
}
