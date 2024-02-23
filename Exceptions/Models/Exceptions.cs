using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    class YearOutOfRangeException : Exception
    {
        public YearOutOfRangeException() { }

        public YearOutOfRangeException(string message) : base(message) { }
    }
    class MonthOutOfRangeException : Exception
    {
        public MonthOutOfRangeException() { }

        public MonthOutOfRangeException(string message) : base(message) { }
    }
    class DayOfMonthException : Exception
    {
        public DayOfMonthException() { }

        public DayOfMonthException(string message) : base(message) { }
    }



}
