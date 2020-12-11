using System;
using System.Collections.Generic;

namespace HashSet_and_SortedSet_01
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));//OUTPUT:True
            foreach (String p in set)
            {
                Console.WriteLine(p);
            }

        }
    }
}
