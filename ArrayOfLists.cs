using System;
using System.ComponentModel;

namespace task1
{
    public class Array<T>
    {
        private LinkedList<int>[] lists = new LinkedList<int>[1];

        public Array()=> lists[0] = new LinkedList<int>();

        public int Length { get { return lists.Length; } }

        public void Insert(int index, int value)
        {

            if (lists.Length-1<index)
            {

                ResizeArray(index);
                LinkedList<int> newlist = new LinkedList<int>();
                newlist.Insert(value);
                lists[index] = newlist;

            }
            else
            {
                if (lists[index]==null)
                {
                    LinkedList<int> newlist = new LinkedList<int>();
                    lists[index] = newlist;
                }
                lists[index].Insert(value);
            }

        }

        public LinkedList<int> Get(int index)
        {

            try
            {
                return lists[index];
            }
            catch (NullReferenceException)
            {

                return null;
            }
            
        }

        private void ResizeArray(int index)
        {

            LinkedList<int>[] array = new LinkedList<int>[index+1];
            lists.CopyTo(array, 0);
            lists = array;
        }

    }
}
