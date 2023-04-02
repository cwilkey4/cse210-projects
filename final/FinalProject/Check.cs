using System;

namespace FinalProject 
{
    public class Check
    {
        private DateOnly _checkOutDate = DateOnly.FromDateTime(DateTime.Now);

        public DateOnly GiveDueDate()
        {
            DateOnly dueDate = _checkOutDate.AddDays(14);

            return dueDate;
        }
    }
}