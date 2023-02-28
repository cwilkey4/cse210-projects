using System;
// This prompts the user to match their breaths to a timer for a specified duration. 

namespace Develop04
{
    public class BreathingActivity : Activity
    {
        private int cwinhale = 4; 
        private int cwexhale = 6; 

        public void BreathCycle()
        {
            // CountDown(duration)
            // while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                ShowSpinner(cwinhale);
                Console.WriteLine("Now breathe out...");
                ShowSpinner(cwexhale);
            }
        }

    }
}