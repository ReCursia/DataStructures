using System.Collections.Generic;

namespace DataStructures.structures.common
{
    public interface IList<T> : IEnumerable<T>
    {
        int Count { get; }

        T this[int index] => ValueAt(index);

        void AddFirst(T data)
        {
            InsertAt(data, 0);
        }

        void AddLast(T data)
        {
            InsertAt(data, Count);
        }

        void InsertAt(T data, int index);
        T ValueAt(int index);

        void RemoveAt(int index);

        void Reverse();
    }
}