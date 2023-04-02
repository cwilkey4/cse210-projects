using System;

namespace FinalProject {
    public class Extension
    {
        private DateTime cwtoday = DateTime.Today;
        private DateTime _cwextension;
        private double cw2months = 60;

        public bool CheckExtension(DateTime cwrequestedDate)
        {
            _cwextension = cwrequestedDate;

            TimeSpan cwdifference = _cwextension - cwtoday;
            double cwdays = (double)cwdifference.TotalDays;
            
            if (cwdays > cw2months)
            {
                return false;
            }
            else if (cwdays > 0 && cwdays < cw2months)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GiveMessage(DateTime cwrequestedDate)
        {
            _cwextension = cwrequestedDate;

            TimeSpan cwdifference = _cwextension - cwtoday;
            double cwdays = (double)cwdifference.TotalDays;
            
            if (cwdays > cw2months)
            {
                return "Please choose a date that is less than two months away.";
            }
            else if (cwdays > 0 && cwdays < cw2months)
            {
                return "";
            }
            else
            {
                return "Please enter a valid date.";
            }
        }

        public string AssignDueDate(string cwitem, DateOnly cwrequestedDate)
        {
            string cwwrittenDate = cwrequestedDate.ToString();
            return $"{cwitem}|{cwwrittenDate}";
        }
    }
}