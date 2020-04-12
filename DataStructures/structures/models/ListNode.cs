namespace DataStructures.structures.models
{
    public class ListNode<T>
    {
        public ListNode(T data, ListNode<T> next = null)
        {
            Next = next;
            Data = data;
        }

        public ListNode<T> Next { get; set; }
        public T Data { get; }
    }
}