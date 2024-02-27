using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioSpiel
{
    internal class GameOver : Exception
    {
        public GameOver() { }
        public GameOver(string message) : base(message) { }
    }
}
