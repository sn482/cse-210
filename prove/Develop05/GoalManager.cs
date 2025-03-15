using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
        Console.WriteLine("✔️ Goal added!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nSelect a goal to record progress:");
        DisplayGoals();
        Console.Write("Enter goal number: ");
        int index;
        if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= goals.Count)
        {
            goals[index - 1].RecordEvent();
            score += goals[index - 1].GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
        Console.WriteLine($" Score: {score} points");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(score);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.SaveString());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            goals.Clear();
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == "SimpleGoal")
                    {
                        goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                    }
                }
            }
            Console.WriteLine("Goals loaded!");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
