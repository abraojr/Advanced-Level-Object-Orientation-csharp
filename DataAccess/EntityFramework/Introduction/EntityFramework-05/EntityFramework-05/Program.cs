using EntityFramework_05.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityFramework_05
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                var tags = context.Tags.AsNoTracking().ToList();

                foreach (var tag in tags)
                {
                    Console.WriteLine(tag.Name);
                }
            }
        }
    }
}
