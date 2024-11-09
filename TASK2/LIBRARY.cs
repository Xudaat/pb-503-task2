using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();


        public void AddBook(Book book)
        {
            Books.Add(book);
        }


        public Book GetBookById(int id)
        {
            return Books.FirstOrDefault(book => book.Id == id);
        }


        public Book GetBookByName(string name)
        {
            return Books.FirstOrDefault(book => book.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }


        public List<Book> GetFilteredBooks(string genre)
        {
            return Books.Where(book => book.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
        }


        public List<Book> GetFilteredBooks(decimal minPrice, decimal maxPrice)
        {
            return Books.Where(book => book.Price >= minPrice && book.Price <= maxPrice).ToList();
        }
    }
}