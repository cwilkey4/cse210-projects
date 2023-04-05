// Logan Ray, Celestia Wilkey, Derek Earl, Vishnu Soranam
// Date: 04/03/2023 || ⓒ copyright all rights reserved, BYU-I CSE 210
// This is part of the abstraction project
using System;

public class Save
{
    public void SaveFile(string cwfileName, string[] cwentries)
    {
        using (StreamWriter outputFile = new StreamWriter(cwfileName, false))
        {     
            foreach (string cwentry in cwentries)
            {
                outputFile.WriteLine(cwentry);
            }                       
                            
            // outputFile.Close();
        }
    }
}