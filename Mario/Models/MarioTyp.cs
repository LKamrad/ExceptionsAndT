using MarioSpiel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioSpiel
{
    class MarioTyp : IState
    {
        public MarioState State { get; set; }

        public virtual void GotFeather()
        {
            Console.WriteLine($"Du bist jetzt CapeMario!");
            State = MarioState.CapeMario;
        }

        public virtual void GotFireFlower()
        {
            Console.WriteLine($"Du bist jetzt FireMario!");
            State = MarioState.FireMario;
        }

        public virtual void GotMushroom()
        {
            Console.WriteLine($"Du bist jetzt SuperMario!");
            State = MarioState.SuperMario;
        }

        public virtual void MetMonster()
        {
            Console.WriteLine($"Du hast ein Monster getroffen");
            State = MarioState.SmallMario;
        }
    }
}
