using System;
using System.Collections.Generic;

class TaskManager
{
    private List<Task> tasks = new List<Task>();

    public void AddTask()
    {
        Console.Write("Enter task name: ");
        string name = Console.ReadLine();
        Console.Write("Enter task description: ");
        string description = Console.ReadLine();

        // Create a simple task and add it to the list
        tasks.Add(new SimpleTask(name, description));
        Console.WriteLine("Task added. Stay focused!");
    }

    public void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks added yet.");
            return;
        }
        Console.WriteLine("Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i].GetStatus()}");
        }
    }

    public void RecordTaskProgress()
    {
        ViewTasks();
        if (tasks.Count == 0)
            return;

        Console.Write("Enter task number to record event: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            tasks[index - 1].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    }
}
