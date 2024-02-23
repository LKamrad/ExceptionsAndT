using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2.Models
{
    internal class RailwayStationException : Exception
    {

        public RailwayStationException() { }    
        public RailwayStationException(string message) : base(message) { }
    }
}
