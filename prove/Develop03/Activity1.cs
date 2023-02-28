using System;
// This is the parent class. All of the child classes will use attributes and methods from this class.

public class Activity
{
    // We need to decide if we want these to be protected or private.
    // If protected, it will be open to all children classes automatically.
    // If private, we will need getters and setters.
    
    private string _activityName;
    private string _description; 

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    // Activity activity1 = new Activity();

    private string startMessage = $"Welcome to the {activityName} activity!";  

    protected int duration; // We are going to prompt the user for this number. It may need to be converted (milliseconds and seconds)
    
    private string endMessage = $"Well done! You've finished {duration} seconds of the {activityName} activity";

    // Methods!
    // countDown()

    public void spinner() // We need it to take a "duration" variable in place of timer
    {
        // For now, the spinner runs for a set time of 4 seconds. We may need to adapt that.
        DateTime startTime = DateTime.Now;
        TimeSpan timer = TimeSpan.FromSeconds(4); 

        while (DateTime.Now - startTime < timer)
        {
            Console.Write("|");
            Thread.Sleep(500);

            Console.Write("\b \b"); 
            Console.Write("/"); 

            Thread.Sleep(500);

            Console.Write("\b \b"); 
            Console.Write("|"); 

            Thread.Sleep(500);

            Console.Write("\b \b"); 
            Console.Write("\\"); 

            Thread.Sleep(500);
            Console.Write("\b \b"); 
        }
    }

}