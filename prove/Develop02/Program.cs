// Logan Ray, Celestia Wilkey, Derek Earl, Vishnu Soranam
// Date: 04/03/2023 || ⓒ copyright all rights reserved, BYU-I CSE 210
// This is part of the abstraction project
using System;

class Program
{
    
    static void Main(string[] args)
    {
        Entry write = new Entry();
        Display display = new Display();
        Save save = new Save();

        string[] cwentries = {};
        string cwfileName;

        display.SetArray(cwentries);

        bool cwrepeat = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (cwrepeat == true)
        { 
            Console.WriteLine(" ");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string cwmenuSelection = Console.ReadLine();

            if (cwmenuSelection == "1")
            {
                    // Write
                string cwprompt = write.GeneratePrompt();
                Console.WriteLine(cwprompt);
                string cwentry = Console.ReadLine();

                    // Save entries after
                
                string cwjournal = display.OrganizeEntry(cwprompt, cwentry);
                display.AddToArray(cwjournal);
                Console.WriteLine(cwjournal);
            }
            else if (cwmenuSelection == "2")
            {
                // Display
                try 
                {
                display.DisplayArray();
                }
                catch
                {
                    Console.WriteLine("You don't have any entries to display!");
                    Console.WriteLine(" ");
                }
            }
            else if (cwmenuSelection == "3")
            {
                // Load
                Console.WriteLine("Which file would you like to load from? ");
                cwfileName = Console.ReadLine();
                
                cwentries = System.IO.File.ReadAllLines(cwfileName);
                display.SetArray(cwentries);

                foreach (string cwentry in cwentries)
                {
                    Console.WriteLine(cwentry);
                }
            }
            else if (cwmenuSelection == "4")
            {
                // Save
                Console.WriteLine("What file would you like to save to? ");
                cwentries = display.GetArray();
                cwfileName = Console.ReadLine();

                save.SaveFile(cwfileName, cwentries);
            }
            else if (cwmenuSelection == "5")
            {
                cwrepeat = false;
            }
        }
    }
}