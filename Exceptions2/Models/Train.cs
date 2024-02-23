using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2.Models
{
    internal class Train
    {

        private int _zugnummer;
        private int _waggons;

        public Train(int zugnummer, int waggons) 
        {
            _zugnummer = zugnummer;
            _waggons = waggons;
        }

        public int Zugnummer { get { return _zugnummer; } set { _zugnummer = value; } }
        public int Waggons { get { return _waggons; } set { _waggons = value; } }

        public override string ToString()
        {
            return $"Train Nr: {_zugnummer} mit {_waggons} waggons";
        }

    }
}
