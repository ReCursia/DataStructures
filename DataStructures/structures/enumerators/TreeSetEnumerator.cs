using System;
using System.Collections;
using System.Collections.Generic;
using DataStructures.structures.models;

namespace DataStructures.structures.enumerators
{
    public class TreeSetEnumerator<T> : IEnumerator<T> where T : IComparable<T>
    {
        private readonly Queue<TreeNode<T>> _queue;
        private readonly TreeNode<T> _root;
        private TreeNode<T> _currentNode;

        public TreeSetEnumerator(TreeNode<T> root)
        {
            _root = root;
            _currentNode = _root;
            _queue = new Queue<TreeNode<T>>();
            FillQueue();
        }

        public bool MoveNext()
        {
            if (_queue.Count == 0) return false;
            _currentNode = _queue.Dequeue();
            return true;
        }

        public void Reset()
        {
            _currentNode = _root;
        }

        public T Current => _currentNode.Data;

        object IEnumerator.Current => _currentNode;

        public void Dispose()
        {
            _queue.Clear();
        }

        private void FillQueue()
        {
            AddNode(_root);
        }

        private void AddNode(TreeNode<T> node)
        {
            if (node == null) return;
            AddNode(node.Left);
            _queue.Enqueue(node);
            AddNode(node.Right);
        }
    }
}