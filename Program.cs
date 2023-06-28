using System;
using task1;

namespace task1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            string[] data = Console.ReadLine().Split(' ');

            HashTable hashtable = new HashTable(N);

            foreach (string s in data)
            {

                hashtable.Insert(Convert.ToInt32(s));

            }

            Console.WriteLine(hashtable.Hashkey);
            hashtable.ShowAllValues();

        }
    }
}

