// Celestia Wilkey, 01/18/2022
// In this program, we create several classes to construct a resume.

using System;

public class Job // company, job title, start year, end year
{
    public string _cwcompany;
    public string _cwjobTitle;
    public int _cwstartYear;
    public int _cwendYear;

    public void ShowJobDesc()
    {
        Console.WriteLine($"{_cwjobTitle} ({_cwcompany}) || {_cwstartYear}-{_cwendYear}");
    }
} 