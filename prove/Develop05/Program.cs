using System;
using System.IO;

namespace Develop05;
class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        string userChoice = "";

        // Goals
        // Goal goal1 = new Goal();
        // goal1.SetGoalName("Simple");
        // goal1.SetGoalDescription("One time goal.");

        // Goal goal2 = new Goal();
        // goal2.SetGoalName("Eternal");
        // goal2.SetGoalDescription("A never ending goal.");

        // Goal goal3 = new Goal();
        // goal3.SetGoalName("Checklist");
        // goal3.SetGoalDescription("A repetitive goal set for a specified number of times.");

        while (userChoice != "6")
        {
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                // Create New Goal
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("Simple Goal");
                Console.WriteLine("Eternal Goal");
                Console.WriteLine("Checklist Goal");

                string goalChoice = Console.ReadLine();

                while (goalChoice != "1" && goalChoice != "2" && goalChoice != "3")
                { 
                    if (goalChoice == "1")
                    {
                        // Simple Goal
                        Simple simple = new Simple();

                        Console.WriteLine("What is the name of your goal? ");
                        string goalName = Console.ReadLine();

                        Console.WriteLine("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();

                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        string points = Console.ReadLine();
                        int goalPoints = int.Parse(points);
                    }
                    else if (goalChoice == "2")
                    {
                        // Eternal Goal

                        Console.WriteLine("What is the name of your goal? ");
                        string goalName = Console.ReadLine();

                        Console.WriteLine("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();

                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        string points = Console.ReadLine();
                        int goalPoints = int.Parse(points);
                    }
                    else if (goalChoice == "3")
                    {
                        // Checklist Goal

                        Console.WriteLine("What is the name of your goal? ");
                        string goalName = Console.ReadLine();

                        Console.WriteLine("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();

                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        string points = Console.ReadLine();
                        int goalPoints = int.Parse(points);

                        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                        string times = Console.ReadLine();
                        int timesWanted = int.Parse(times);

                        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                        string bonus = Console.ReadLine();
                        int bonusPoints = int.Parse(points);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a value from 1 to 3.");
                    }
                }
                

            }
            else if (userChoice == "2")
            {
                // List Goals
                Console.WriteLine("The goals are:");

            }
            else if (userChoice == "3")
            {
                // Save Goals
                Console.WriteLine("What is the filename for the goal? ");
                string goalFile = Console.ReadLine();

                // Write to file
                using (StreamWriter outputFile = new StreamWriter(goalFile))
                {
                    // You can add text to the file with the WriteLine method
                    outputFile.WriteLine("This will be the first line in the file."); //Goal name, desc, etc
                            
                    // You can use the $ and include variables just like with Console.WriteLine
                    string color = "Blue";
                    outputFile.WriteLine($"My favorite color is {color}");
                }

            }
            else if (userChoice == "4")
            {
                Console.WriteLine("What is the filename for the goal file? ");
                string goalFile = Console.ReadLine();
                // Load Goals
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("The goals are: ");
                // Record Event

                Console.WriteLine("Which goal did you accomplish? ");
                string finished = Console.ReadLine();
                int finishedGoal = int.Parse(finished);
            }
            else if (userChoice == "6")
            {
                // Quit
            }
        }
    }
}