using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask first for the magic number. (Later, change this to a randomized number)
        Console.Write("What is the magic number? ");
        string cwuserNumber = Console.ReadLine();
        int cwmagicNumber = int.Parse(cwuserNumber);

        string input = "yes";
        
        while (input == "yes")
        {
            // Ask for a guess
            Console.WriteLine("What is your guess? ");
            string cwuserGuess = Console.ReadLine();
            int cwguessedNumber = int.Parse(cwuserGuess);

            // Using an if statement, determine if the user needs to guess higher or lower. (No Loops for now)
            if (cwguessedNumber > cwmagicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (cwguessedNumber < cwmagicNumber)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.Write("You guessed it!");
                input = "nope";
            }
        }

    }
}