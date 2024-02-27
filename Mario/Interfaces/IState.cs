using MarioSpiel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioSpiel
{
    interface IState
    {
        MarioState State { get; set; }
        //IState ClassState { get; }

        void GotMushroom();
        void GotFireFlower();

        void GotFeather();
        void MetMonster();
    }
}
