using EntityFramework_04.Data;
using System;
using System.Linq;

namespace EntityFramework_04
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                var tags = context.Tags.ToList();

                foreach (var tag in tags)
                {
                    Console.WriteLine(tag.Name);
                }
            }
        }
    }
}
