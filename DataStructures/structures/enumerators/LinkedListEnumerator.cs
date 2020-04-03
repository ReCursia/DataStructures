using System.Collections;
using System.Collections.Generic;
using DataStructures.structures.models;

namespace DataStructures.structures.enumerators
{
    public class LinkedListEnumerator<T> : IEnumerator<T>
    {
        private readonly ListNode<T> _head;
        private ListNode<T> _currentListNode;

        public LinkedListEnumerator(ListNode<T> head)
        {
            _head = head;
            _currentListNode = null;
        }

        public bool MoveNext()
        {
            if (_currentListNode == null)
            {
                _currentListNode = _head;
                return _head != null;
            }

            if (_currentListNode.Next == null) return false;
            _currentListNode = _currentListNode.Next;
            return true;
        }

        public void Reset()
        {
            _currentListNode = _head;
        }

        object IEnumerator.Current => _currentListNode;

        public void Dispose()
        {
            //Nothing to dispose
        }

        public T Current => _currentListNode.Data;
    }
}