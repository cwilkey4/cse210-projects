using System;
// This is the parent class. All of the child classes will use attributes and methods from this class.

namespace Develop04
{
    public class Activity
    {
        // We need to decide if we want these to be protected or private.
        // If protected, it will be open to all children classes automatically.
        // If private, we will need getters and setters.
        
        private string _cwactivityName = "";
        private string _cwdescription = ""; 
        protected int _cwduration;

        public string StartMessage()
        {
            return $"Welcome to the {_cwactivityName}! {_cwdescription}";
        }

        public string GetActivityName()
        {
            return _cwactivityName;
        }

        public void SetActivityName(string cwactivityName)
        {
            _cwactivityName = cwactivityName;
        }

        public string GetDescription()
        {
            return _cwdescription;
        }

        public void SetDescription(string cwdescription)
        {
            _cwdescription = cwdescription;
        }
        
        public int GetDuration()
        {
            return _cwduration;
        }

        public void SetDuration(int cwduration) 
        {
            _cwduration = cwduration;
        }

        public string EndMessage()
        {
            return $"Well done! You've finished {_cwduration} seconds of the {_cwactivityName}!";
        }

        // Methods!
        public DateTime CountDown(int cwtime)
        {
            DateTime cwstartTime = DateTime.Now;
            TimeSpan cwseconds = TimeSpan.FromSeconds(cwtime);
            DateTime cwendTime = cwstartTime + cwseconds;
            return cwendTime;
        }

        public void ShowSpinner(int cwseconds) 
        {
            while (cwseconds / 2 > 0)
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

                cwseconds -= cwseconds;
            }
        }

    }
}