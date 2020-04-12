using System;

namespace DataStructures.algorithms
{
    public static class MergeSort
    {
        private static void Sort<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            if (left >= right) return;
            var middle = (left + right) / 2;
            Sort(array, left, middle);
            Sort(array, middle + 1, right);
            Merge(array, left, middle, right);
        }

        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Merge<T>(T[] array, in int left, int middle, in int right) where T : IComparable<T>
        {
            var leftArray = new T[middle - left + 1];
            var rightArray = new T[right - middle];

            Array.Copy(array, left, leftArray, 0, middle - left + 1);
            Array.Copy(array, middle + 1, rightArray, 0, right - middle);

            var i = 0;
            var j = 0;
            for (var k = left; k < right + 1; k++)
                if (i == leftArray.Length)
                {
                    array[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i].CompareTo(rightArray[j]) <= 0)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
        }
    }
}