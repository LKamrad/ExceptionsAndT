using MarioSpiel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioSpiel
{
    class FireMario : MarioTyp, IState
    {

        public FireMario()
        {
            State = MarioState.FireMario;
        }


        public override void GotFireFlower()
        {

        }

        public override void GotMushroom()
        {
            
        }


    }
}
