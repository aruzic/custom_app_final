namespace custom_app.Data.Models
{
    public class Book_Author
    {
        public int Id { get; set; }

        //Navigation Properties
        public int BookId { get; set; }

        public Book Books { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}