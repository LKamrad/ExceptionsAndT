using Exceptions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Person person = new Person();
            //person.Name = "Test";
            //person.Vorname = "Testvorname";

            //Console.Write("Alter: ");
            //person.Alter = int.Parse(Console.ReadLine());
            //Console.WriteLine(person.Alter);

            SimpleDate sd = new SimpleDate();

            sd.Year = 2024;
            sd.Month = 2;
            sd.Day = 29;

            Console.WriteLine(sd);

        }
    }
}
