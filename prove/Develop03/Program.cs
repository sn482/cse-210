using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Scripture (it will pick a random scripture)
        Scripture scripture = new Scripture();

        // Loop until all words are hidden or user quits
        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(2); // Hides two words at a time
        }

        Console.Clear();
        Console.WriteLine("All words are hidden! Program ending.");
    }
}
