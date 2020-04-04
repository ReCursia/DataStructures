using System;

namespace DataStructures.structures.models
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public TreeNode(T data, TreeNode<T> left = null, TreeNode<T> right = null)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public T Data { get; }
    }
}