using EntityFramework_03.Data;
using System;
using System.Linq;

namespace EntityFramework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                var tag = context.Tags.FirstOrDefault(x => x.Id == 2);

                context.Remove(tag);
                context.SaveChanges();
            }
        }
    }
}
