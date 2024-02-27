using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioSpiel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Mario mario = new Mario();
            //Console.WriteLine(mario);
            //mario.GotMushroom();
            //Console.WriteLine(mario);
            //mario.GotFireFlower();
            //Console.WriteLine(mario);
            //mario.GotFeather();
            //Console.WriteLine(mario);
            //mario.GotCoins(4800);
            //Console.WriteLine(mario);
            //mario.MetMonster();
            //Console.WriteLine(mario);
            //mario.MetMonster();
            //Console.WriteLine(mario);
            //mario.MetMonster();
            //Console.WriteLine(mario);



            Console.WriteLine($"\n\nSmallMario Test:");
            mario = new Mario();
            Console.WriteLine(mario);
            mario.GotMushroom();
            Console.WriteLine(mario);
            mario.MetMonster();
            Console.WriteLine(mario);
            mario.GotFireFlower();
            Console.WriteLine(mario);
            mario.MetMonster();
            Console.WriteLine(mario);
            mario.GotFeather();
            Console.WriteLine(mario);
            mario.MetMonster();
            Console.WriteLine(mario);
            mario.MetMonster();
            Console.WriteLine(mario);
            mario.MetMonster();
            Console.WriteLine(mario);
            //mario.MetMonster();
            //Console.WriteLine(mario);
            //mario.MetMonster();
            //Console.WriteLine(mario);



            //Console.WriteLine($"\n\nFireMario Test:");
            //mario = new Mario();
            //Console.WriteLine(mario);
            //mario.GotFireFlower();
            //Console.WriteLine(mario);
            //mario.GotFireFlower();
            //Console.WriteLine(mario);
            //mario.GotMushroom();
            //Console.WriteLine(mario);
            //mario.GotFeather();
            //Console.WriteLine(mario);


            //Console.WriteLine($"\n\nCapeMario Test:");
            //mario = new Mario();
            //Console.WriteLine(mario);
            //mario.GotFeather();
            //Console.WriteLine(mario);
            //mario.GotFeather();
            //Console.WriteLine(mario);
            //mario.GotMushroom();
            //Console.WriteLine(mario);
            //mario.GotFireFlower();
            //Console.WriteLine(mario);


            Console.WriteLine($"\n\nSuperMario Test:");
            mario = new Mario();
            Console.WriteLine(mario);
            mario.GotMushroom();
            Console.WriteLine(mario);
            mario.GotMushroom();
            Console.WriteLine(mario);
            mario.GotFireFlower();
            Console.WriteLine(mario);
            mario.GotMushroom();
            Console.WriteLine(mario);
            mario.MetMonster();
            Console.WriteLine(mario);
            mario.GotMushroom();
            Console.WriteLine(mario);
            mario.GotFeather();
            Console.WriteLine(mario);
            mario.GotMushroom();
            Console.WriteLine(mario);
            mario.MetMonster();
            Console.WriteLine(mario);
            mario.GotMushroom();
            Console.WriteLine(mario);

        }
    }
}
