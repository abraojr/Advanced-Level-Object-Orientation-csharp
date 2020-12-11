using GetHashCode_and_Equals.Entities;
using System;

namespace GetHashCode_and_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b)); //OUTPUT: True
            Console.WriteLine(a == b); //OUTPUT: False
            Console.WriteLine(a.GetHashCode()); //OUTPUT: -257079879
            Console.WriteLine(b.GetHashCode()); //OUTPUT: -257079879
        }
    }
}
