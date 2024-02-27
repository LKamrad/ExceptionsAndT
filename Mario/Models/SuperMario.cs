using MarioSpiel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioSpiel
{
    class SuperMario : MarioTyp, IState
    {
        public SuperMario(Mario mario) : base(mario)
        {
            State = MarioState.SuperMario;
        }


        public override void GotMushroom()
        {
            
        }

    }
}
