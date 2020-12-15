using Delegates_05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program that, from a list of products, generates a new list containing the names of the products in capital letters.*/

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(func).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            /* The function "Select" (belonging to the LINQ) is a function that applies a function to all elements of a collection, thus generating a new 
             *collection (of the type IEnumerable).*/
        }
    }
}
