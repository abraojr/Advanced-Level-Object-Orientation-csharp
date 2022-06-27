using EntityFramework_02.Data;
using System;
using System.Linq;

namespace EntityFramework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
                tag.Name = ".NET";
                tag.Slug = "dotnet";

                context.Update(tag);
                context.SaveChanges();
            }
        }
    }
}
