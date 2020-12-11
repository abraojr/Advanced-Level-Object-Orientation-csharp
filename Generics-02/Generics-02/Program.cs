using Generics_02.Entities;
using Generics_02.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Generics_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A consulting company wants to evaluate the performance of products, employees, among other things. One of the calculations that this company 
             *needs to do is to find the biggest among a set of elements. Make a program that reads a set of N products, and then shows the most expensive of
             *them.*/

            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }
            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Most expensive: ");
            Console.WriteLine(max);
        }
    }
}
