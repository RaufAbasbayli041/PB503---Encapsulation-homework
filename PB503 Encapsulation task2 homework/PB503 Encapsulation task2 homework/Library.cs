using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PB503_Encapsulation_task2_homework
{
    public class Library
    {
        public Book[] Books = new Book[0];

        public void AddBook(Book books)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[^1] = books;
        }

        public Book GetBookById(int id)
        {
            foreach (Book book in Books)
            {
                if (book.Id == id)
                    return book;
            }
            return null;
        }

        public Book GetBookByName(string name)
        {
            foreach (Book book in Books)
            {
                if (book.Name.ToLower().Contains(name.ToLower()))
                    return book;
            }

            return null;
        }

        public Book[] GetFilteredBooks(string value)
        {
            Book[] wantedbooks = new Book[0];
            foreach (var book in Books)
            {
                if (book.Genre == value)
                {
                    Array.Resize(ref wantedbooks, wantedbooks.Length + 1);
                    wantedbooks[^1] = book;
                }
            }
            return wantedbooks;
        }

        public Book[] GetFiltredBooks(double minPrice, double maxPrice)
        {
            Book[] wantedbooks = new Book[0];
            foreach (var book in Books)
            {
                if (book.Price >= minPrice && book.Price <= maxPrice)
                {
                    Array.Resize(ref wantedbooks, wantedbooks.Length + 1);
                    wantedbooks[^1] = book;
                }
            }
            return wantedbooks;
        }
    }
}
