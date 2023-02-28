using System;
// // This activity is similar to the Reflecting Activity, but it only contains one list. It aims to get multiple responses from the user and tally them up.

namespace Develop04
{
    public class ListingActivity : Activity
    {
        string [] deprompts = {
        "How did the spirit touch your life today?",
        "What was the highlight of your day?",
        "Why was today good/bad?",
        "When did you do a good thing and see blessings?"
        };

        private string _deprompt;

        public int GetPrompt(int deduration) 
        {
            Random random = new Random();
            _deprompt = deprompts[random.Next(0,4)];
            Console.WriteLine("Get ready!");
            ShowSpinner(4);
            Console.WriteLine("List as many responses as you can to the following prompt!");
            Console.WriteLine(_deprompt);
            int _deresponseCount = 0;

            DateTime deendTime = CountDown(deduration);

            while (DateTime.Now < deendTime)
            {
                string deuserInput;
                deuserInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(deuserInput))
                {
                    _deresponseCount += 1;
                }
                else
                {
                    Console.WriteLine("Write something!");
                }
            }
            return _deresponseCount;
        }
    }
}