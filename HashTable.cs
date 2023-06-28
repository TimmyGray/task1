using System;

namespace task1
{
    public class HashTable
    {
        private int hashkey;
        public int Hashkey { get { return hashkey; } }
        
        public Array<ListNode<int>> values = new Array<ListNode<int>>();

        public void Insert(int newValue)
        {
            int index = Hashing(newValue);
            values.Insert(index, newValue); 
           
        }

        public int[] Get(int key)
        {
            LinkedList<int> list = values.Get(key);
            if (list!=null)
            {
                int[] samevalues = list.GetAll();
                return samevalues;

            }
            else
            {
                return new int[0];
            }
        }

        private int Hashing(int newValue)
        {
            int key = newValue % hashkey;
            return key;
        }

        public void ShowAllValues()
        {

            for (int i = 0; i < values.Length; i++)
            {
                
                int[] samehashvalues = Get(i);

                Console.Write($"{i}: ");
                for (int k = 0; k < samehashvalues.Length ; k++)
                {
                    Console.Write($"{samehashvalues[k]}"+" ");
                }

                Console.WriteLine();
            }
     

        }

        public HashTable(int _hashkey)=>hashkey = _hashkey;

    }
}
