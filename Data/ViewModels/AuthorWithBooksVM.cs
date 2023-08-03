using System.Collections.Generic;
using System.Globalization;

namespace myBooks.Data.ViewModels
{
    public class AuthorWithBooksVM
    {
        public string FullName { get; set; }
        public List<string> BookTitles { get; set; }
    }
}
