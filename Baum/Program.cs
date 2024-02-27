using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baum
{
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

            Console.WriteLine("---------------------------");
            INode<String> node = cityTree.Search("Frankfurt");

            Console.WriteLine(node);
            foreach(var c in node)
            {
                Console.WriteLine(c);
            }

            


        }
    }
}
