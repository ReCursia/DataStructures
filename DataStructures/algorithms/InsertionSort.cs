using System;

namespace DataStructures.algorithms
{
    public static class InsertionSort
    {
        private static void Swap<T>(ref T e1, ref T e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while (j > 1 && array[j - 1].CompareTo(key) > 0)
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }
        }
    }
}