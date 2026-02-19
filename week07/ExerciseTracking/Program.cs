using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2025", 30, 4.8),
            new Cycling("03 Nov 2025", 40, 15.0),
            new Swimming("03 Nov 2025", 25, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}