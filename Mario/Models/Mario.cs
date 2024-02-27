﻿using MarioSpiel;
using MarioSpiel.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioSpiel
{
    class Mario
    {

        private int _lifeCount;
        private IState _state;
        private int _coins;


        /// <summary>
        /// Class <c>Mario</c> Erstellt ein Mario spiel in Text format
        /// </summary>
        public Mario()
        {
            _lifeCount = 3;
            _state = new SmallMario();
            _coins = 0;
        }
        public int LifeCount { get { return _lifeCount;  } }



        /// <summary>
        /// Method <c>GetState</c> Erstellt eine neue Instanz 
        /// von Mariotyp (abhängig von enum MarioState)
        /// </summary>
        /// <exception cref="UnknownMarioState">
        /// Wirft die Ausname wenn stateID ist nicht in MarioState
        /// </exception>
        public IState GetState(MarioState stateID)
        {


            if (stateID == MarioState.SmallMario)
            {
                return new SmallMario();
            }
            if (stateID == MarioState.SuperMario)
            {
                return new SuperMario();
            }
            if (stateID == MarioState.FireMario)
            {
                return new FireMario();
            }
            if (stateID == MarioState.CapeMario)
            {
                return new CapeMario();
            }
            throw new UnknownMarioState($"Unbekanter State {stateID}");
        }

        /// <summary>
        /// Method <c>GotCoins</c> Addiert die Münze
        /// </summary>
        public void GotCoins(int coinsGained)
        {
            _coins += coinsGained;
            Console.WriteLine($"+{coinsGained} coins");
            ExtralifeCheck();
        }

        /// <summary>
        /// Method <c>ExtralifeCheck</c> Überpruft ob der 
        /// Spieler hat genug geld für ein Extra leben
        /// falls ja gibt es und entfernt das Geld
        /// </summary>
        public void ExtralifeCheck()
        {
            if(_coins >= 4000)
            {
                _lifeCount++;
                _coins -= 4000;
                Console.WriteLine($"+ Extra life!");
            }
        }


        /// <summary>
        /// Method <c>LostLife</c> Erniedrigt lifeCount, falls LifeCount
        /// </summary>
        /// <exception cref="GameOver">
        /// Wirft die Ausname wenn _lifeCount ist gleich 0
        /// </exception>
        public void LostLife()
        {
            _lifeCount--;
            if (_lifeCount == 0)
            {
                throw new GameOver("Du hast verloren!");
            }
        }



        /// <summary>
        /// Method <c>MarioStateAktualisieren</c> Ändert Mario state
        /// </summary>
        public void MarioStateAktualisieren(MarioState stateID)
        {
            //State = stateID;
            _state = GetState(stateID);
        }



        /// <summary>
        /// Method <c>GotMushroom</c> Schick die information 
        /// nach IState typ von Mario und addiert 100 coins
        /// </summary>
        public void GotMushroom()
        {
            _state.GotMushroom();
            GotCoins(100);
            MarioStateAktualisieren(_state.State);
        }


        /// <summary>
        /// Method <c>GotFireFlower</c> Schick die information 
        /// nach IState typ von Mario und addiert 200 coins
        /// </summary>
        public void GotFireFlower()
        {
            _state.GotFireFlower();
            GotCoins(200);
            MarioStateAktualisieren(_state.State);
        }

        /// <summary>
        /// Method <c>GotFeather</c> Schick die information 
        /// nach IState typ von Mario und addiert 300 coins
        /// </summary>
        public void GotFeather()
        {
            _state.GotFeather();
            GotCoins(300);
            MarioStateAktualisieren(_state.State);

        }


        /// <summary>
        /// Method <c>MetMonster</c> Schick die information 
        /// nach IState typ von Mario und entscheided was 
        /// wird passieren falls Mario den Monster begegnet hat
        /// </summary>
        public void MetMonster()
        {
            _state.MetMonster();
            if(_state is SmallMario)
            {
                LostLife();
            }
            else
            {
                MarioStateAktualisieren(_state.State);
            }
        }

        /// <summary>
        /// Method <c>ToString</c> Gibt die Ausgabe in State:coins:lives format
        /// </summary>
        public override string ToString()
        {
            Console.ForegroundColor = (ConsoleColor)_state.State;   
            return $"Mario: {_state.State,10} Coins: {_coins,5} Lifes: {_lifeCount,2}";
            
        }
    }
}
