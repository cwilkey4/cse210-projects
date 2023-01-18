using System;

class Program
{
    static void Main(string[] args)
    {
        // Intro. Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        List<int> cwnumbers = new List<int>();

        int cwuserNumber = -1;
        while (cwuserNumber != 0)
        {
            Console.Write("Add a number to the list! (0 to finish)");

            string cwuserInput = Console.ReadLine();
            cwuserNumber = int.Parse(cwuserInput);

            if (cwuserNumber != 0)
            {
                cwnumbers.Add(cwuserNumber);
            }
        }

        // 1. Compute the sum, or total, of the numbers in the list.
        int cwtotal = 0;
        foreach (int cwnumber in cwnumbers)
        {
            cwtotal += cwnumber;
        }

        Console.WriteLine($"The total is {cwtotal}.");

        // 2. Compute the average of the numbers in the list.
        float cwavgTotal = (float)cwtotal;
        float cwaverage = (cwavgTotal / cwnumbers.Count);
        Console.WriteLine($"The average is {cwaverage}.");

        // 3. Find the maximum, or largest, number in the list.
        int cwmax = cwnumbers[0];
        foreach (int cwnumber in cwnumbers)
        {
            if (cwnumber > cwmax)
            {
                cwmax = cwnumber;
            }
        }
        Console.WriteLine($"The largest number is {cwmax}.");
    }
}

// Stretch challenges available for this assignment!