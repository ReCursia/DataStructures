using System.Collections.Generic;

namespace DataStructures.structures.common
{
    public interface ILinkedList<T> : IEnumerable<T>
    {
        int Count { get; }

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