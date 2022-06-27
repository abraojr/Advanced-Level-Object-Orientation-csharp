using EntityFramework_02.Data;
using EntityFramework_02.Models;
using System;

namespace EntityFramework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            var user = new User
            {
                Name = "Abrão Astério Jr",
                Slug = "abraoastjr",
                Email = "abrao@email.com",
                Bio = "Student",
                Image = "https://...",
                PasswordHash = "123321456"
            };

            var category = new Category
            {
                Name = "Backend",
                Slug = "backend"
            };

            var post = new Post
            {
                Author = user,
                Category = category,
                Body = "<p>Hello World</p>",
                Slug = "getting-started-with-ef-core",
                Summary = "In this article we will learn EF Core",
                Title = "Getting Started With EF Core",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
