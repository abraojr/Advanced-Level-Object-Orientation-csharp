using EntityFramework_01.Data;
using EntityFramework_01.Models;
using System;
using System.Linq;

namespace EntityFramework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            // Adding a User
            context.Users.Add(new User
            {
                Bio = "UserTest",
                Email = "test@email.com",
                Image = "htps://...",
                Name = "User Test",
                PasswordHash = "1234",
                Slug = "user-test"
            });
            context.SaveChanges();

            // Adding a post
            var user = context.Users.FirstOrDefault(x => x.Id == 4);
            var post = new Post
            {
                Author = user,
                Body = "My Article",
                Category = new Category
                {
                    Name = "Frontend",
                    Slug = "frontend"
                },
                CreateDate = DateTime.Now,
                Slug = "my-article",
                Summary = "In this summary we will see...",
                Title = "My Article"
            };
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
