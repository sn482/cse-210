using System;
using System.IO;
using System.Collections.Generic;

public class FileManager
{
    public void SaveTasks(List<Task> tasks, string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // In this basic version, we simply save the type and status of each task.
            foreach (Task t in tasks)
            {
                string type = "";
                if (t is SimpleTask)
                    type = "SimpleTask";
                else if (t is EternalTask)
                    type = "EternalTask";
                else if (t is ChecklistTask)
                    type = "ChecklistTask";
                writer.WriteLine($"{type}|{t.GetStatus()}");
            }
        }
        Console.WriteLine("Tasks saved to file.");
    }

    public List<Task> LoadTasks(string filename)
    {
        List<Task> tasks = new List<Task>();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                // This load functionality is unfinished.
                Console.WriteLine("Loaded from file: " + line);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
        return tasks;
    }
}
