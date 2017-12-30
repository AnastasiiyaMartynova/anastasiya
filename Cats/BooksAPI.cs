using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public static class BooksAPI
    {
        public static Book addBook(String title, String author)
        {
            var book = new Book(title, author);
            BookMap.addBookToDB(book);
            return book;
        }

        public static Book getBookById(int Id)
        {
            return BookMap.getBookById(Id);
        }

        public static void getFiveTopBooks()
        {
            BookMap.getTopFiveBooks();
        }

    }
}
