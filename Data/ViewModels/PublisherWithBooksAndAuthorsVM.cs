using System.Collections.Generic;

namespace myBooks.Data.ViewModels
{
    public class PublisherWithBooksAndAuthorsVM
    {
        public string Name { get; set; }
        public List<BookAuthorVM> BookAuthors { get; set; } 
    }
}
