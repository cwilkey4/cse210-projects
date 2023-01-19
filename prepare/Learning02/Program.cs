// Celestia Wilkey, 01/18/2022
// In this program, we create several classes to construct a resume.

using System;

class Program
{
    static void Main(string[] args)
    {
        Job cwjob1 = new Job();
        cwjob1._cwcompany = "Phillips 66";
        cwjob1._cwjobTitle = "Electrician";
        cwjob1._cwstartYear = 2007;
        cwjob1._cwendYear = 2022;

        Job cwjob2 = new Job();
        cwjob2._cwcompany = "Best Western";
        cwjob2._cwjobTitle = "Front Desk Receptionist";
        cwjob2._cwstartYear = 1991;
        cwjob2._cwendYear = 2005;

        Resume cwresume1 = new Resume();
        cwresume1._cwname = "Amber Wilkey";
        cwresume1._cwjobs.Add(cwjob1);
        cwresume1._cwjobs.Add(cwjob2);

        cwresume1.ShowResume();
    }
}