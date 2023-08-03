namespace myBooks.Data.Models
{
    public class Book_Author
    {
        public int Id { get; set; }

        //Navigations Properties (many-to-many)
        public int BookId { get; set; }
        public Book Book { get; set; }

        //Navigations Properties (many-to-many)
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
