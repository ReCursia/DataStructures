using System;
using DataStructures.structures;
using DataStructures.structures.common;

namespace DataStructures
{
    internal class Program
    {
        private static void Main()
        {
            IList<int> list = new LinkedList<int>();
            list.AddFirst(5);
            list.AddFirst(6);
            list.AddLast(7);
            list.AddFirst(8);
            Console.Out.WriteLine(list.ValueAt(0));
            Console.Out.WriteLine(list.ValueAt(3));
            Console.Out.WriteLine(list);
            list.RemoveAt(2);
            list.InsertAt(5, 2);
            Console.Out.WriteLine(list);
            Console.Out.WriteLine(list[2]);
            list.Reverse();
            Console.Out.WriteLine(list);
        }
    }
}