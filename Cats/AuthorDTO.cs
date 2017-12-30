using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class AuthorsDTO
    {
        public AuthorsDTO(Author author)
        {
            Id = author.Id;
            Name = author.Name;
            Book = author.Book;
        }


        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual Book Book { get; set; }

    }
}
