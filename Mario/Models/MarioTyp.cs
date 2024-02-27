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

        protected Mario _mario;

        public MarioTyp(Mario mario)
        {
            _mario = mario;
        }

        public virtual void GotFeather()
        {
            Console.WriteLine($"Du bist jetzt CapeMario!");
            State = MarioState.CapeMario;
            _mario.State = new CapeMario(_mario); 
        }

        public virtual void GotFireFlower()
        {
            Console.WriteLine($"Du bist jetzt FireMario!");
            State = MarioState.FireMario;
            _mario.State = new FireMario(_mario); 
        }

        public virtual void GotMushroom()
        {
            Console.WriteLine($"Du bist jetzt SuperMario!");
            State = MarioState.SuperMario;
            _mario.State = new SuperMario(_mario); 
        }

        public virtual void MetMonster()
        {
            Console.WriteLine($"Du hast ein Monster getroffen");
            State = MarioState.SmallMario;
            _mario.State = new SmallMario(_mario); 
        }
    }
}
