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
                Bio = "test2",
                Email = "test2@email.com",
                GitHub = "abraojr",
                Image = "https://...",
                Name = "Test2",
                PasswordHash = "123",
                Slug = "test-2"
            };

            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
