// Celestia Wilkey, 01/18/2022
// In this program, we create several classes to construct a resume.

using System;
public class Resume // name (string), jobs (list)
{
    public string _cwname;
    public List<Job> _cwjobs = new List<Job>();

    public void ShowResume()
    {
        Console.WriteLine($"Name: {_cwname}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _cwjobs)
        {
            job.ShowJobDesc();
        }
    }
}