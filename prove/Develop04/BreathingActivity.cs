using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by guiding you to breathe in and out slowly. Focus on your breathing.") { }

    protected override void RunActivity()
    {
        int timeLeft = _duration;
        while (timeLeft > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(5);
            Console.WriteLine("Breathe out...");
            ShowCountdown(5);
            timeLeft -= 10;
        }
    }
}
