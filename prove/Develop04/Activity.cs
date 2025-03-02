using System;
using System.Threading;

abstract class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_activityName}...");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        RunActivity();
        EndActivity();
    }

    protected abstract void RunActivity();

    protected void EndActivity()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed {_activityName} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(". ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
