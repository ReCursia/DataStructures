using System;
using System.Collections;
using System.Collections.Generic;
using DataStructures.structures.enumerators;
using DataStructures.structures.models;

namespace DataStructures.structures
{
    public class TreeSet<T> : common.ISet<T> where T : IComparable<T>
    {
        private const int Equal = 0;
        private const int LessThan = -1;
        private const int GreaterThan = 1;
        private TreeNode<T> _root;

        public TreeSet()
        {
            _root = null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new TreeSetEnumerator<T>(_root);
        }

        public bool Add(T data)
        {
            if (Contains(data)) return false;

            if (_root == null)
                _root = new TreeNode<T>(data);
            else
                AddElem(data, _root);

            return true;
        }

        public bool Contains(T data)
        {
            return FindElem(data, _root);
        }

        public bool Remove(T data)
        {
            if (!Contains(data)) return false;
            _root = RemoveElem(data, _root);
            return true;
        }

        private static TreeNode<T> RemoveElem(T data, TreeNode<T> node)
        {
            if (node == null) return null;
            var compareTo = data.CompareTo(node.Data);
            if (compareTo == LessThan)
            {
                node.Left = RemoveElem(data, node.Left);
            }
            else if (compareTo == GreaterThan)
            {
                node.Right = RemoveElem(data, node.Right);
            }
            else
            {
                if (node.Right == null) return node.Left;
                if (node.Left == null) return node.Right;
                var temp = node;
                node = MinElem(temp.Right);
                node.Right = DeleteMin(temp.Right);
                node.Left = temp.Left;
            }

            return node;
        }

        private static TreeNode<T> DeleteMin(TreeNode<T> node)
        {
            if (node.Left == null) return node.Right;
            node.Left = DeleteMin(node.Left);
            return node;
        }

        private static TreeNode<T> MinElem(TreeNode<T> node)
        {
            return node.Left == null ? node : MinElem(node.Left);
        }

        private static bool FindElem(T data, TreeNode<T> node)
        {
            if (node == null)
                return false;

            var compareTo = data.CompareTo(node.Data);
            return compareTo switch
            {
                Equal => true,
                LessThan => FindElem(data, node.Left),
                GreaterThan => FindElem(data, node.Right),
                _ => false
            };
        }

        private static void AddElem(T data, TreeNode<T> node)
        {
            if (data.CompareTo(node.Data) == LessThan)
            {
                if (node.Left != null)
                    AddElem(data, node.Left);
                else
                    node.Left = new TreeNode<T>(data);
            }
            else
            {
                if (node.Right != null)
                    AddElem(data, node.Right);
                else
                    node.Right = new TreeNode<T>(data);
            }
        }
    }
}