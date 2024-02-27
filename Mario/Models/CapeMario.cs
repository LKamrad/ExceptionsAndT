using MarioSpiel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioSpiel
{
    class CapeMario : MarioTyp, IState
    {

        public CapeMario()
        {
            State = MarioState.CapeMario;
        }
        public override void GotFeather()
        {
            
        }



        public override void GotMushroom()
        {
            
        }


    }
}
