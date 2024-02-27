using MarioSpiel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioSpiel
{
    class SmallMario : MarioTyp, IState
    {

        public SmallMario()
        {
            State = MarioState.SmallMario;
        }


        public override void MetMonster()
        {
            Console.WriteLine($"Du hast ein Monster getroffen");
        }
    }
}
