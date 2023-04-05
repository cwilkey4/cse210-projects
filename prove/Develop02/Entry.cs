// Logan Ray, Celestia Wilkey, Derek Earl, Vishnu Soranam
// Date: 04/03/2023 || ⓒ copyright all rights reserved, BYU-I CSE 210
// This is part of the abstraction project
using System;

public class Entry
{
    public string GeneratePrompt()
    {
        string[] cwPrompts = new string[5]; 
        cwPrompts[0] = "I am happy because... ";
        cwPrompts[1] = "What did I learn today? ";
        cwPrompts[2] = "What do I want to do tomorrow to make it great? ";
        cwPrompts[3] = "Today, I was inspired by... ";
        cwPrompts[4] = "How did I give and receive appreciation today? ";
        Random cwRandomize = new Random();
        int cwPromptNumber = cwRandomize.Next(4);
            // Console.WriteLine(cwPrompts[cwPromptNumber]);
            // string cwUserEntry = Console.ReadLine();
            // Remove this part later
            // Console.WriteLine(cwUserEntry);
        return cwPrompts[cwPromptNumber];
    }
}
