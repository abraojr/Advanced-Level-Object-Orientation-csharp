using EntityFramework_03.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityFramework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            var posts = context
                .Posts
                .AsNoTracking()
                .Include(x => x.Author)
                .OrderBy(x => x.LastUpdateDate)
                .ToList();

            foreach (var post in posts)
            {
                Console.WriteLine($"{post.Title} written by {post.Author?.Name}");
            }
        }
    }
}
