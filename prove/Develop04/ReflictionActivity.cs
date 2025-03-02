using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : Activity
{
    private static readonly List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "How did you feel before, during, and after this experience?",
        "What challenges did you face, and how did you overcome them?",
        "What strengths or qualities did you develop in this situation?",
        "What did this experience teach you about yourself?",
        "How has this shaped the way you handle similar situations today?",
        "If you were in this situation again, would you do anything differently?",
        "What is the biggest lesson you want to take from this?",
        "Take a deep breath and reflect on everything you’ve learned.",
        "As we finish, what is one word or phrase that captures the meaning of this experience?"
    };

    public ReflectionActivity() : base("Reflection Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience.") { }

    protected override void RunActivity()
    {
        Random random = new();
        
        
        ShowSpinner(3);

        int timeLeft = _duration;
        int questionIndex = 0;

        while (timeLeft > 0 && questionIndex < _questions.Count)
        {
            Console.WriteLine(_questions[questionIndex]);
            ShowSpinner(2);  // Small pause after the question appears
            Console.WriteLine("Take your time to reflect...");
            ShowSpinner(7);  // Longer reflection pause
            timeLeft -= 9;
            questionIndex++;
        }

        Console.WriteLine("Take a deep breath and appreciate your personal growth.");
        ShowSpinner(3);
    }
}
