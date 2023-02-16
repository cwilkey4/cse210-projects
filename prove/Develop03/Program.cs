// Logan Ray, Celestia Wilkey, Derek Earl, Vishnu Soranam
// Date: 02/10/2023 || ⓒ copyright all rights reserved, BYU-I CSE 210
// This is part of the encapsulation project.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        string wipbook = reference.getBook();
        int wipchapter = reference.getChapter();
        int wipverse = reference.getVerse();
        int wipendVerse = reference.getEndVerse();

        Scripture scripture = new Scripture();
        string wipscriptureWords = scripture.getScripture();

        string wipuserInput = "";
        while (wipuserInput != "quit")
        {
            Console.WriteLine("Can you memorize this scripture?");
            Console.WriteLine($"{wipbook} {wipchapter}:{wipverse}-{wipendVerse}");

            Console.WriteLine(wipscriptureWords);
            Console.WriteLine("Press Enter to Continue or type 'quit' to quit.");

            wipuserInput = Console.ReadLine();

            Console.Clear();
        }

        Console.WriteLine("You did it! Awesome Job!");

    }
}