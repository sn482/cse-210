using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private static readonly List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    protected override void RunActivity()
    {
        Random random = new();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        ShowSpinner(3);
        Console.WriteLine("Start listing items. Press Enter on an empty line to finish early.");

        List<string> responses = new();
        int timeLeft = _duration;

        while (timeLeft > 0)
        {
            Console.Write("→ ");
            string response = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(response)) // Allows early exit
            {
                break;
            }

            responses.Add(response);
            timeLeft -= 2; // Assume each entry takes about 2 seconds
        }

        Console.WriteLine($"\nYou listed {responses.Count} items. Well done!");
        ShowSpinner(3);
    }
}
