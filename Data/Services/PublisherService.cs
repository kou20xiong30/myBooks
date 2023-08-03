using myBooks.Data.Models;
using myBooks.Data.ViewModels;
using System;
using System.Linq;

namespace myBooks.Data.Services
{
    
    public class PublisherService
    {
        private AppDbContext _context;

        public PublisherService(AppDbContext context)
        {
            _context = context;
        }

        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name
            };

            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }

        public PublisherWithBooksAndAuthorsVM GetPublisherData(int publisherId)
        {
            var _publisherData = _context.Publishers.Where(p => p.Id == publisherId).Select(p => new PublisherWithBooksAndAuthorsVM()
            {
                Name = p.Name,
                BookAuthors = p.Books.Select(n => new BookAuthorVM()
                {
                    BookName = n.Title,
                    BookAuthors = n.Book_Authors.Select(n => n.Author.FullName).ToList()
                }).ToList()
            }).FirstOrDefault();

            return _publisherData;
        }

        public void DeletePublisherById(int id)
        {
            var _publisher = _context.Publishers.FirstOrDefault(p => p.Id ==id);

            if ( _publisher != null )
            {
                _context.Publishers.Remove(_publisher);
            }

            _context.SaveChanges();
        }
    }
}
