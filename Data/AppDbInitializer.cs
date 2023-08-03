using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using myBooks.Data.Models;
using System;
using System.Linq;

namespace myBooks.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st Book Titile",
                        Description = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        //Author = "1st Author",
                        CoverUrl = "https://www.youtube.com/@HmongStory/videos",
                        DateAdded = DateTime.Now
                    },
                    new Book()
                    {
                        Title = "2nd Book Titile",
                        Description = "2nd Book Description",
                        IsRead = false,
                        Genre = "Self-Help",
                        //Author = "2nd Author",
                        CoverUrl = "https://www.youtube.com/@HmongStory",
                        DateAdded = DateTime.Now
                    },
                    new Book()
                    {
                        Title = "3rd Book Titile",
                        Description = "3rd Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-7),
                        Rate = 3,
                        Genre = "Cook",
                        //Author = "3rd Author",
                        CoverUrl = "https://www.youtube.com/@HmongStory",
                        DateAdded = DateTime.Now
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
