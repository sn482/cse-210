using System;
using System.Collections.Generic;

class StudyPlanner
{
    private List<StudyTask> tasks = new List<StudyTask>();

    public void AddTask()
    {
        Console.Write("Enter task name: ");
        string name = Console.ReadLine();
        Console.Write("Enter subject: ");
        string subject = Console.ReadLine();

        StudyTask task = new StudyTask(name, subject);
        tasks.Add(task);
        Console.WriteLine("Task added! Stay focused.");
    }

    public void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks yet. Time to set some goals!");
            return;
        }

        Console.WriteLine("\nStudy Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i].GetTaskDetails()}");
        }
    }

    public void CompleteTask()
    {
        ViewTasks();
        if (tasks.Count == 0) return;

        Console.Write("Enter the number of the task you completed: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            tasks[index - 1].MarkComplete();
            Console.WriteLine("Great job! Keep pushing forward.");
        }
        else
        {
            Console.WriteLine("Invalid input. Try again.");
        }
    }
}
