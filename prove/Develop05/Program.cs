using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n Eternal Quest Menu ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Progress");
            Console.WriteLine("3. View Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int points = int.Parse(Console.ReadLine());

                    Console.WriteLine("Choose goal type: 1. Simple  2. Eternal  3. Checklist");
                    string type = Console.ReadLine();
                    if (type == "1") manager.AddGoal(new SimpleGoal(name, desc, points));
                    else if (type == "2") manager.AddGoal(new EternalGoal(name, desc, points));
                    else if (type == "3")
                    {
                        Console.Write("Enter required times: ");
                        int required = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, desc, points, required, bonus));
                    }
                    break;
                case "2": manager.RecordEvent(); break;
                case "3": manager.DisplayGoals(); break;
                case "4": manager.SaveGoals(); break;
                case "5": manager.LoadGoals(); break;
                case "6": running = false; break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }
}
