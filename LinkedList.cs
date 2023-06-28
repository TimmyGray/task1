using System;

namespace task1
{
    public class LinkedList<T>
    {
        public ListNode<T> head;
        public ListNode<T> tail;
        int count=0;

        public void Insert(T value)
        {

            ListNode<T> newnode = new ListNode<T>();
            newnode.Insert(value);

            if (head == null)
            {
                head = newnode;
            }
            else
            {
                tail.next = newnode;

            }
            tail = newnode;
            count++;

        }

        public T[] GetAll()
        {
            ListNode<T> curnode = head;
            T[] res = new T[count];
            int i = 0;
            while (curnode != null)
            {
                res[i] = curnode.value;
                curnode = curnode.next;
                i++;
            }


            return res;
        }

    }
}
