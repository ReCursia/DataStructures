namespace DataStructures.structures.models
{
    public class Node<T>
    {
        public Node(T data, Node<T> next = null)
        {
            Next = next;
            Data = data;
        }

        public Node<T> Next { get; set; }
        public T Data { get; }
    }
}