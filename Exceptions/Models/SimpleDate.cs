using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    internal class SimpleDate
    {
        private int _year;
        private int _month;
        private int _day;

        Dictionary<int, int> _dates = new Dictionary<int, int>() { {1,31 },{2,28 }, {3,31 }, {4,30 }, {5,31 }, {6,30 }, {7,31 }, {8,31 }, {9,30 }, {10,31 }, {11,30 }, {12,31 } };
        public int Year 
        {
            get { return _year; }
            set 
            { 
                if (value < 1 || value > 9999)
                {
                    throw new YearOutOfRangeException("Nur Werte zwischen 1 und 9999 erlaubt!");
                }
                _year = value;
            } 
        }
        public int Month
        {
            get { return _month; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new MonthOutOfRangeException("Nur Werte zwischen 1 und 12 erlaubt!");
                }
                _month = value;
            }
        }
        public int Day
        {
            get { return _day; }
            set
            {
                int leap = 0;
                if (_month == 2 && IsLeapYear(_year) == false)
                {
                    leap++;
                }
                if (value < 1 || value > (_dates[_month] + leap))
                {
                    throw new DayOfMonthException($"Nur Werte zwischen 1 und {(_dates[_month] + leap)} erlaubt!");
                }

                _day = value;
            }
        }

        public override string ToString()
        {
            return $"{_day}/{_month}/{_year}";
        }

        private bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
