// Celestia Wilkey, 01/05/2022
// This is the second assignment. We are required to convert the number grade into a letter grade
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Grade Percentage: ");
        string cwvalueFromUser = Console.ReadLine();
        int gradePercent = int.Parse(cwvalueFromUser);
        string plusMinus;

        int remainder = gradePercent % 10;
        if (remainder >= 7)
        {
            plusMinus = "+";
        }
        else if (remainder < 3)
        {
            plusMinus = "-";
        }
        else
        {
            plusMinus = "";
        }

        if (gradePercent >= 90)
        {
            string cwletterGrade = "A";
            if (plusMinus == "+")
            {
                Console.WriteLine($"Your grade is an \"{cwletterGrade}\"! ");
            }
            else
            {
                Console.WriteLine($"Your grade is an \"{cwletterGrade}{plusMinus}\"! ");
            }
        }
        else if (gradePercent < 90 && gradePercent >= 80)
        {
            string cwletterGrade = "B";
            Console.WriteLine($"Your grade is a \"{cwletterGrade}{plusMinus}\"! ");
        }
        else if (gradePercent < 80 && gradePercent >= 70)
        {
            string cwletterGrade = "C";
            Console.WriteLine($"Your grade is a \"{cwletterGrade}{plusMinus}\"! ");
        }
        else if (gradePercent < 70 && gradePercent >= 60)
        {
            string cwletterGrade = "D";
            Console.WriteLine($"Your grade is a \"{cwletterGrade}{plusMinus}\"! ");
        }
        else
        {
            string cwletterGrade = "F";
            Console.WriteLine($"Your grade is an \"{cwletterGrade}\"! ");
        }
    }
}