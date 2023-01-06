// Celestia Wilkey, 01/05/2022
// This is our class' first assignment. We need to prompt the user for their name and then print it out in a "Bond, James Bond" style.
using System; 

class Program
{
    static void Main(string[] args) 
    {
        Console.Write("What is your first name? ");
        string cwfirst = Console.ReadLine();
        Console.Write("What is your last name? ");
        string cwlast = Console.ReadLine();
        Console.WriteLine("");
        Console.Write($"Your name is {cwlast}, {cwfirst} {cwlast}.");
    }
}