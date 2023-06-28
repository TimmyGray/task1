using System;

namespace task1
{
    public class ListNode<T>
    {
        public T value;
        public ListNode<T> next;

        public void Insert(T newValue)
        {
            
            value = newValue;

        }
    }
}
