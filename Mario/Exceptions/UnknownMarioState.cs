using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioSpiel.Exceptions
{
    internal class UnknownMarioState : Exception
    {
        public UnknownMarioState():base() { }

        public UnknownMarioState(string message) : base(message) { }
    }
}
