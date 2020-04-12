using System;
using System.Collections.Generic;
using DataStructures.algorithms;
using DataStructures.structures;

namespace DataStructures
{
    internal static class Program
    {
        private static void Main()
        {
            TestLinkedList();
            TestBinaryTree();
            TestMergeSort();
            TestInsertionSort();
        }

        private static void TestInsertionSort()
        {
            var array = new[] {1, 2, 3, 4, 5, 6, 2123, 124, 12, 123, 120, 12312};
            OutputArray(array);
            InsertionSort.Sort(array);
            OutputArray(array);
        }

        private static void TestMergeSort()
        {
            var array = new[] {1, 2, 3, 4, 5, 6, 2123, 124, 12, 123, 120, 12312};
            OutputArray(array);
            MergeSort.Sort(array);
            OutputArray(array);
        }

        private static void OutputArray<T>(IEnumerable<T> array)
        {
            foreach (var value in array) Console.Write(value + " ");
            Console.WriteLine();
        }

        private static void TestBinaryTree()
        {
            structures.common.ISet<int> tree = new TreeSet<int>();
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
            structures.common.IList<int> list = new structures.LinkedList<int>();
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