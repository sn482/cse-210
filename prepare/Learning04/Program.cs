
using System;

class Program
{
    static void Main()
    {
        // Test the Assignment class
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary()); // Output: Samuel Bennett - Multiplication

        // Test the MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3 Problems 8-19");
        Console.WriteLine(mathAssignment.GetSummary()); // Output: Roberto Rodriguez - Fractions
        Console.WriteLine(mathAssignment.GetHomeworkList()); // Output: Section 7.3 Problems 8-19

        // Test the WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary()); // Output: Mary Waters - European History
        Console.WriteLine(writingAssignment.GetWritingInformation()); // Output: Mary Waters - The Causes of World War II
    }
}
