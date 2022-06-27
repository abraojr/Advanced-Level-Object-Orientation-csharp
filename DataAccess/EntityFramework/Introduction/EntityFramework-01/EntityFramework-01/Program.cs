using EntityFramework_01.Data;
using EntityFramework_01.Models;
using System;

namespace EntityFramework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
                context.Tags.Add(tag);
                context.SaveChanges();
            }
        }
    }
}
