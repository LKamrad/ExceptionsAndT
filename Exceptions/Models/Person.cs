using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    class Person
    {
        private int _alter;
        public string Name { get; set; }
        public string Vorname { get; set; }
        public int Alter
        {
            get { return _alter; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Kein negatives Alter erlaubt!");
                }
                _alter = value; }

        }

    }
}
