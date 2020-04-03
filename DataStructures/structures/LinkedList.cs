using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DataStructures.structures.common;
using DataStructures.structures.enumerators;
using DataStructures.structures.models;

namespace DataStructures.structures
{
    public class LinkedList<T> : ILinkedList<T>
    {
        private Node<T> _head;

        public LinkedList()
        {
            Count = 0;
            _head = null;
        }

        public int Count { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(_head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T ValueAt(int index)
        {
            var i = 0;
            foreach (var elem in this)
            {
                if (index == i)
                    return elem;
                i++;
            }

            throw new IndexOutOfRangeException();
        }

        public void InsertAt(T data, int index)
        {
            if (index == 0)
            {
                _head = new Node<T>(data, _head);
            }
            else if (index <= Count)
            {
                var currentNode = _head;
                for (var i = 0; currentNode != null; i++)
                {
                    if (i == index - 1) currentNode.Next = new Node<T>(data, currentNode.Next);
                    currentNode = currentNode.Next;
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

            Count++;
        }

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                _head = _head.Next;
            }
            else if (index <= Count)
            {
                var currentNode = _head;
                for (var i = 0; currentNode != null; i++)
                {
                    if (i == index - 1) currentNode.Next = currentNode.Next.Next;
                    currentNode = currentNode.Next;
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

            Count--;
        }

        public void Reverse()
        {
            Node<T> previousNode = null;
            var currentNode = _head;
            while (currentNode != null)
            {
                var next = currentNode.Next;
                currentNode.Next = previousNode;
                previousNode = currentNode;
                currentNode = next;
            }

            _head = previousNode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append('[');
            foreach (var elem in this) result.Append(elem).Append(", ");
            result.Append(']');
            return result.ToString();
        }
    }
}