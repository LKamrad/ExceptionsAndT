using Exceptions2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Train train1 = new Train(123,22);
            Train train2 = new Train(124, 12);
            Train train3 = new Train(125, 32);
            //Train train4 = new Train(126, 52);
            Train train5 = new Train(127, 32);



            RailwayStation BochumHbf = new RailwayStation("Bochum Hbf", 100);


            BochumHbf.AddTrain(train1);
            BochumHbf.AddTrain(train2);
            BochumHbf.AddTrain(train3);
            //BochumHbf.AddTrain(train4);
            BochumHbf.AddTrain(train5);
            Console.WriteLine(BochumHbf);

            Train temp = BochumHbf.SendTrainAway();
            Console.WriteLine("Schicke weg");
            Console.WriteLine(temp);
            temp = BochumHbf.SendTrainAway();
            Console.WriteLine("Schicke weg");
            Console.WriteLine(temp);
            temp = BochumHbf.SendTrainAway();
            Console.WriteLine("Schicke weg");
            Console.WriteLine(temp);
            Console.WriteLine("Was bleibt übrig");
            Console.WriteLine(BochumHbf);
            temp = BochumHbf.SendTrainAway();
            Console.WriteLine("Schicke weg");
            Console.WriteLine(temp);
            try
            {
                temp = BochumHbf.SendTrainAway();
                Console.WriteLine("Schicke weg");
                Console.WriteLine(temp);
            }
            catch(RailwayStationException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
