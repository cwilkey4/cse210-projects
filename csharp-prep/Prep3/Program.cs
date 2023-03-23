using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask first for the magic number. (Later, change this to a randomized number)
        Random cwrandomGenerator = new Random();    //
        int cwNumber = cwrandomGenerator.Next(1, 101); //
        // Console.Write("What is the magic number? ");
        // string cwuserNumber = Console.ReadLine();
        // int cwmagicNumber = int.Parse(cwuserNumber);

        string input = "yes";
        int cwcount = 0;
        
        while (input == "yes")
        {
            cwcount = cwcount + 1;
            // Ask for a guess
            Console.WriteLine("What is your guess? ");
            string cwuserGuess = Console.ReadLine();
            int cwguessedNumber = int.Parse(cwuserGuess);

            // Using an if statement, determine if the user needs to guess higher or lower. (No Loops for now)
            if (cwguessedNumber > cwNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (cwguessedNumber < cwNumber)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.Write("You guessed it!");
                input = "nope";
            }
        }
        string cwcountTotal = cwcount.ToString();
        
        Console.WriteLine($"It took you {cwcountTotal} tries!");

    }

    // Stretch Challenges can still be done.
}