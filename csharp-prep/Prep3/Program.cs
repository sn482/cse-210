using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1,101);
        int guess = 0;

        Console.WriteLine("Welcome to the Magic Number game");

        while (guess != magicNumber)
        {
            Console.Write("what is your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");

            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You got it Good Job");
            }
        }
    }

}