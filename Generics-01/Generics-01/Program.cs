using System;

namespace Generics_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Make a program that reads a set of whole N numbers (N from 1 to 10), and then print these numbers in an organized way. Then inform what was 
             *the first value informed.*/

            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
