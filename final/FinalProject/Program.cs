using System;

class Program
{
    static void Main()
    {
        StudyPlanner planner = new StudyPlanner();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nStudy Planner");
            Console.WriteLine("1. Add Study Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task as Done");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    planner.AddTask();
                    break;
                case "2":
                    planner.ViewTasks();
                    break;
                case "3":
                    planner.CompleteTask();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Keep going! You're doing great!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
