using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise14
{
    internal class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public string WeekdayInDutch()
        {
            CultureInfo netherlands = new CultureInfo("nl-NL");
            DateTime dateTime = new DateTime(_year, _month, _day);

            return dateTime.ToString("dddd", netherlands);
        }
    }
}
