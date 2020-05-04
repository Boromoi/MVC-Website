using System;

namespace TimeCalculatorApp
{
    public class Berekeningen
    {
        public string hours;
        public string minutes;

        private DateTime dateTimeBeginTijd;
        private DateTime dateTimeEindTijd;

        public Berekeningen(DateTime dateTimeBeginTijd, DateTime dateTimeEindTijd)
        {
            this.dateTimeBeginTijd = dateTimeBeginTijd;
            this.dateTimeEindTijd = dateTimeEindTijd;

            hours = (dateTimeEindTijd - dateTimeBeginTijd).Hours.ToString();
            minutes = (dateTimeEindTijd - dateTimeBeginTijd).Minutes.ToString();
        }
    }
}
