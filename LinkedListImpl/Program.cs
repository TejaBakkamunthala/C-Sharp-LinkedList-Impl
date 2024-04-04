using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImpl
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Display();
            list.InsertAtParticularPosition(2,50);
            list.RemoveFisrtNode();
           list.RemovalLastNode();

            Console.ReadKey();

        }
    }
}
