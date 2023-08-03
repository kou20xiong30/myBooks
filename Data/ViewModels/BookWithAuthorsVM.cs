using System.Collections.Generic;
using System;

namespace myBooks.Data.ViewModels
{
    public class BookWithAuthorsVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genre { get; set; }
        //public string Author { get; set; }
        public string CoverUrl { get; set; }

        //Navigation Properties
        public string PublisherName { get; set; }
        public List<String> AuthorNames { get; set; }
    }
}
