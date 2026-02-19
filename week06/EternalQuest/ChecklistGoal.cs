using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;

            //  Creativity added at this point
            Console.WriteLine($"Progress: {_amountCompleted}/{_target}");

            if (_amountCompleted == _target)
            {
                Console.WriteLine("🏆 Checklist Goal Fully Completed!");
                Console.WriteLine($"Bonus Earned: {_bonus} points!");
                return _points + _bonus;
            }

            return _points;
        }

        Console.WriteLine("This checklist goal is already complete.");
        return 0;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}
