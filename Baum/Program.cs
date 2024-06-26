﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Baum
{
    class Test1
    {
        public Test1()
        {

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Tree<String> cityTree = new Tree<String>("Frankfurt");

            cityTree.AddToParent("Frankfurt", "Mannheim").Add("Karlsruhe").Add("Augsburg");
            cityTree.AddToParent("Frankfurt", "Würzburg");
            cityTree.AddToParent("Frankfurt", "Kassel").Add("München"); ;
            cityTree.AddToParent("Würzburg", "Nürnberg").Add("Stuttgart");
            cityTree.AddToParent("Würzburg", "Erfurt");

            Console.WriteLine("PreOrder : \n" +
                   String.Join(", ", cityTree.PreOrderValues()));

            Console.WriteLine("PostOrder : \n" +
                   String.Join(", ", cityTree.PostOrderValues()));



            Console.ReadKey();

        }
    }
}
