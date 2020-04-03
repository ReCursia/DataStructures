using System;
using System.Collections.Generic;

namespace DataStructures.structures.common
{
    public interface ISet<T> : IEnumerable<T> where T : IComparable<T>
    {
        void Add(T data);

        void Contains(T data);

        void Remove(T data);
    }
}