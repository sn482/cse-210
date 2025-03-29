using System;

class Program
{
    static void Main()
    {
        TaskManager manager = new TaskManager();
        bool running = true;
        
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Task planner");
            Console.WriteLine("1. Add Simple Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Record Task Event");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    manager.AddTask();
                    break;
                case "2":
                    manager.ViewTasks();
                    break;
                case "3":
                    manager.RecordTaskProgress();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
            
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
