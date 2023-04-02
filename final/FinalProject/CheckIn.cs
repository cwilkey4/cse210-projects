using System;

namespace FinalProject {
    public class CheckIn {
        //
        public DateOnly RetrieveDate(string cwdate)
        {
            DateOnly cwcheckoutDate = DateOnly.ParseExact(cwdate, "MM/dd/yyyy");

            return cwcheckoutDate;
        }

        public double CheckFee(DateTime cwdueDate)
        {
            DateTime cwtoday = DateTime.Today;

            TimeSpan cwdifference = cwtoday - cwdueDate;

            double cwdays = (double)cwdifference.TotalDays;

            if (cwdays > 0)
            {
                // This is an overdue fee

                double cwfee = cwdays * 0.1D;

                return cwfee;
            }
            else
            {
                return 0;
            }

            // private DateOnly cwtoday = DateOnly.FromDateTime(DateTime.Now);
            // TimeSpan cwdifference = cwdueDate - cwtoday;
            // int cwdays = cwdifference.TotalDays;

            // Will need to change this method to return an integer

        }

        // public int GiveFee()
        // {
        //     //
        // }
    }
}