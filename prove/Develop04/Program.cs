using System;
// Logan Ray, Celestia Wilkey, Derek Earl, Vishnu Soranam
// Date: 02/21/2023 || ⓒ copyright all rights reserved, BYU-I CSE 210
// This is part of the inheritance project.

namespace Develop04
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool vsrepeat = true;
            while (vsrepeat == true)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Listing Activity");
                Console.WriteLine("3. Start Reflecting Activity");
                Console.WriteLine("4. Quit");

                Console.WriteLine("What would you like to do? (1-4)");
                string vsuserSelection = Console.ReadLine();

                // Activities
                Activity activity1 = new Activity();
                activity1.SetActivityName("Breathing Activity");
                activity1.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                Activity activity2 = new Activity();
                activity2.SetActivityName("Reflecting Activity");
                activity2.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                Activity activity3 = new Activity();
                activity3.SetActivityName("Listing Activity");
                activity3.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                Activity activity = new Activity();

                if (vsuserSelection == "1")
                {
                    Console.WriteLine(activity1.StartMessage());

                    Console.WriteLine("How long, in seconds, would you like your session to be?");
                    string userDuration = Console.ReadLine();
                    int duration = int.Parse(userDuration);
                    activity1.SetDuration(duration);

                    Console.WriteLine("Get Ready!");
                    activity.ShowSpinner(8);

                    // Do Activity
                    DateTime endTime = activity.CountDown(duration);
                    while (DateTime.Now < endTime)
                    {
                        BreathingActivity breathe = new BreathingActivity();
                        breathe.BreathCycle();
                    }

                    Console.WriteLine(activity1.EndMessage());
                }
                else if (vsuserSelection == "2")
                {
                    Console.WriteLine(activity2.StartMessage());

                    Console.WriteLine("How long, in seconds, would you like your session to be?");
                    string userDuration = Console.ReadLine();
                    int duration = int.Parse(userDuration);
                    activity2.SetDuration(duration);

                    // Do Activity
                    ListingActivity list = new ListingActivity();
                    
                    int _responseCount = list.GetPrompt(duration); // duration needs to be converted to DateTime
                    string responseCount = _responseCount.ToString();

                    if (_responseCount != 0)
                    {
                        Console.WriteLine($"Time's up! You listed {responseCount} item!");
                    }
                    else
                    {
                        Console.WriteLine($"Time's up! You listed {responseCount} items!");
                    }
                    Console.WriteLine(activity2.EndMessage());
                }
                else if (vsuserSelection == "3")
                {                
                    Console.WriteLine("How long, in seconds, would you like your session to be?");
                    string userDuration = Console.ReadLine();
                    int duration = int.Parse(userDuration);

                    // Do Activity
                    ReflectingActivity reflect = new ReflectingActivity(duration);
                    reflect.Start();
                }
                else
                {
                    Console.WriteLine("Thank you for using the Mindfulness Activities!");
                    vsrepeat = false;
                }
            }
        }
    }
}