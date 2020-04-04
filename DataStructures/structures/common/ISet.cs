using System;
using System.Collections.Generic;

namespace DataStructures.structures.common
{
    public interface ISet<T> : IEnumerable<T> where T : IComparable<T>
    {
        bool Add(T data);

        bool Contains(T data);

        bool Remove(T data);
    }
}