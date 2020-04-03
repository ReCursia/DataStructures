using System;
using DataStructures.structures;
using DataStructures.structures.common;

namespace DataStructures
{
    internal class Program
    {
        private static void Main()
        {
            var list = new LinkedList<string>() as ILinkedList<string>;
            list.AddFirst("Hello");
            list.AddFirst("Portal gun");
            list.AddLast("Testing here");
            list.AddFirst("Once more!!");
            Console.Out.WriteLine(list);
            list.Reverse();
            Console.Out.Write(list);
        }
    }
}