using System.Collections.Generic;

namespace Books
{
    public class BookDTO
    {
        public BookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Author = book.Author;
            Rating = book.Rating;
        }

        public BookDTO()
        {

        }

        public virtual int Id { get; protected set; }
        public virtual string Title { get; set; }
        public virtual string Author { get; set; }

        public virtual double Rating { get; set; }
    }
}