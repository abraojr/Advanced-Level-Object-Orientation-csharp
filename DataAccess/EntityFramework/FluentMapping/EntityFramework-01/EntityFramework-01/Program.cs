using EntityFramework_01.Data;
using System;

namespace EntityFramework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();
        }
    }
}
