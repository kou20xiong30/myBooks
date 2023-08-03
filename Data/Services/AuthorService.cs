using myBooks.Data.Models;
using myBooks.Data.ViewModels;
using System;
using System.Linq;

namespace myBooks.Data.Services
{
    
    public class AuthorService
    {
        private AppDbContext _context;

        public AuthorService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName
            };

            _context.Authors.Add(_author);
            _context.SaveChanges();
        }

        public AuthorWithBooksVM GetAuthorWithBooks(int authorId) 
        { 
            var _author = _context.Authors.Where(a => a.Id == authorId).Select(n => new AuthorWithBooksVM()
            {
                FullName = n.FullName,
                BookTitles = n.Book_Authors.Select(b => b.Book.Title).ToList()

            }).FirstOrDefault();

            return _author;
        }
    }
}
