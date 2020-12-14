using Extension_methods_01.Extensions;
using System;

namespace Extension_methods_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Let's create an extension method called "ElapsedTime()" in the struct DateTime to present a DateTime object in the form of elapsed time, which
             *can be in hours (if less than 24h) or in days otherwise.*/

            DateTime dt = new DateTime(2020, 12, 14, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
