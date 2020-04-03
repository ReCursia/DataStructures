using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.structures
{
    public class TreeSet<T> : common.ISet<T> where T : IComparable<T>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(T data)
        {
            throw new NotImplementedException();
        }

        public void Contains(T data)
        {
            throw new NotImplementedException();
        }

        public void Remove(T data)
        {
            throw new NotImplementedException();
        }
    }
}