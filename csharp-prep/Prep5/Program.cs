// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
// //          Turn each of these into functions to be called!
//         DisplayWelcome();

//         // string cwuserName = PromptUserName();
//         int cwuserNumber = PromptUserNumber();

//         int cwuserSquared = SquareNumber(cwuserNumber);

//         DisplayResult(cwuserName, cwuserSquared);
//     }

// //      DisplayWelcome - Displays the message, "Welcome to the Program!"'
//     static void DisplayWelcome()
//     {
//         Console.WriteLine("Welcome to the Program!");
//     }
// //      PromptUserName - Asks for and returns the user's name (as a string)
//     // static string PromptUserName()
//     // {
//     //     Console.WriteLine("What is your name? ");
//     //     string cwuserName = Console.ReadLine();
//     //     Console.WriteLine($"Nice to meet you, {cwuserName}!");
//     // }

// //      PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
//     static int PromptUserNumber()
//     {
//         Console.WriteLine("What's your favorite number? ");
//         string cwfavoriteNumber = Console.ReadLine();
//         int cwNumber = int.Parse(cwfavoriteNumber);
//         return cwNumber;
//     }

// //      SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
//     static int SquareNumber(int cwnumber)
//     {
//         int cwsquared = cwnumber * cwnumber;
//         return cwsquared;
//     }

// //      DisplayResult - Accepts the user's name and the squared number and displays them.
//     static void DisplayResult(string cwuserName, int cwsquared)
//     {
//         Console.WriteLine($"{cwuserName}, your favorite number squared is {cwsquared}.");
//     }

// }
