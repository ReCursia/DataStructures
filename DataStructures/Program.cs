using System;
using DataStructures.structures;
using DataStructures.structures.common;

namespace DataStructures
{
    internal class Program
    {
        private static void Main()
        {
            //TestLinkedList();
            TestBinaryTree();
        }

        private static void TestBinaryTree()
        {
            ISet<int> tree = new TreeSet<int>();
            tree.Add(5);
            tree.Add(6);
            tree.Add(9);
            tree.Add(1);
            tree.Add(4);
            tree.Add(8);
            tree.Add(-15);
            tree.Remove(1);
            Console.Out.WriteLine(tree.Contains(1));
            Console.Out.WriteLine(tree.Contains(9));
            foreach (var elem in tree) Console.Out.WriteLine(elem);
        }

        private static void TestLinkedList()
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