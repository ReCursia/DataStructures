using System.Collections;
using System.Collections.Generic;
using DataStructures.structures.models;

namespace DataStructures.structures.enumerators
{
    public class LinkedListEnumerator<T> : IEnumerator<T>
    {
        private readonly Node<T> _head;
        private Node<T> _currentNode;

        public LinkedListEnumerator(Node<T> head)
        {
            _head = head;
            _currentNode = null;
        }

        public bool MoveNext()
        {
            if (_currentNode == null)
            {
                _currentNode = _head;
                return _head != null;
            }

            if (_currentNode.Next == null) return false;
            _currentNode = _currentNode.Next;
            return true;
        }

        public void Reset()
        {
            _currentNode = _head;
        }

        object IEnumerator.Current => _currentNode;

        public void Dispose()
        {
            //Nothing to dispose
        }

        public T Current => _currentNode.Data;
    }
}