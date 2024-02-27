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
        public IState ClassState { get; private set; }

        public virtual void GotFeather()
        {
            Console.WriteLine($"Du bist jetzt CapeMario!");
            State = MarioState.CapeMario;
            ClassState = new CapeMario();
        }

        public virtual void GotFireFlower()
        {
            Console.WriteLine($"Du bist jetzt FireMario!");
            State = MarioState.FireMario;
            ClassState = new FireMario();
        }

        public virtual void GotMushroom()
        {
            Console.WriteLine($"Du bist jetzt SuperMario!");
            State = MarioState.SuperMario;
            ClassState = new SuperMario();
        }

        public virtual void MetMonster()
        {
            Console.WriteLine($"Du hast ein Monster getroffen");
            State = MarioState.SmallMario;
            ClassState = new SmallMario();
        }
    }
}
