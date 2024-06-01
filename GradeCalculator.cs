﻿using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a numerical grade
        Console.Write("Enter a numerical grade (0-100): ");
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        if (int.TryParse(input, out int grade))
        {
            // Check if the grade is within the valid range
            if (grade >= 0 && grade <= 100)
            {
                // Determine the letter grade
                string letterGrade;
                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                // Display the letter grade
                Console.WriteLine($"The letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Please enter a grade between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numerical grade.");
        }
    }
}
