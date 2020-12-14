using Extension_methods_02.Extensions;
using System;

namespace Extension_methods_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Let's create an extension method called "Cut(int)" in the String class to receive an integer value as parameter and generate a cutout of the 
             *original string of that size.*/

            string s1 = "Good morning dear students";
            Console.WriteLine(s1.Cut(10)); //OUTPUT: Good morni...
        }
    }
}
