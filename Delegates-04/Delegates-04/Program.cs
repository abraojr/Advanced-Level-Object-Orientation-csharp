using Delegates_04.Entities;
using System;
using System.Collections.Generic;

namespace Delegates_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program that, from a list of products, increases the price of the products by 10%.*/

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}

