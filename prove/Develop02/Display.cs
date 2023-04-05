// This is part of the abstraction project
using System;

public class Display
{
    // Displays Date, Prompt, and Entry
    // Example:
    // Date: 12/9/2022 -- Prompt: If I had one thing I could do over today, what would it be?
    // Speak more kindly to my children
    string _cwentry;
    string[] _cwentries = {};
    public string OrganizeEntry(string cwprompt, string cwentry)
    {
        DateOnly cwentryDate = DateOnly.FromDateTime(DateTime.Now);
        string cwdate = cwentryDate.ToString();
        _cwentry =  $"Date: {cwdate} -- Prompt: {cwprompt} {Environment.NewLine}{cwentry}";

        // I might not need to return this
        return $"Date: {cwdate} -- Prompt: {cwprompt} {Environment.NewLine}{cwentry}";
    }

    public void AddToArray(string cwentry)
    {
        Array.Resize(ref _cwentries, _cwentries.Length + 1);
        _cwentries[_cwentries.Length - 1] = _cwentry;
    }

    public void SetArray(string[] cwentries)
    {
        _cwentries = cwentries;
    }

    public string[] GetArray()
    {
        return _cwentries;
    }

    public void DisplayArray()
    {
        foreach (string cwitem in _cwentries)
        {
            Console.WriteLine(cwitem);
            Console.WriteLine(" ");
        }
    }

}