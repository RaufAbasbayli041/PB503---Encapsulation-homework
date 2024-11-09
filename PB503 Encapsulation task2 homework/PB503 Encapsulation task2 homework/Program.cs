namespace PB503_Encapsulation_task2_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Gulliver's Travels", 5, "Science fiction");
            Book book2 = new Book(2, "Martin Iden", 6.5, "Romance");
            Book book3 = new Book(3, "Mysterious Island", 7.2, "Adventure novel");
            Book book4 = new Book(4, "Tom Sawyer", 8, " Children's literature");


            Library library1 = new Library();

            library1.AddBook(book1);
            library1.AddBook(book2);
            library1.AddBook(book3);
            library1.AddBook(book4);

            //foreach(var library in library1.Books)
            //{
            //    Console.WriteLine(library.Name);
            //}

            Console.WriteLine(library1.GetBookById(2).Genre);




            //Book wantedBook = library1.GetBookByName("iden");

            //if (wantedBook != null)
            //{
            //    Console.WriteLine(wantedBook.Id);
            //}
            //else
            //{
            //    Console.WriteLine("tapilmadi");
            //}

            //Book[] wantedBooks = library1.GetFilteredBooks("Romance");

            //if (wantedBook != null)
            //{
            //    foreach (var book in wantedBooks)
            //    {
            //        Console.WriteLine(book.Id);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("no book");
            //}
                


            //Book[] wantedBooks = library1.GetFiltredBooks(6,7.2);
            //{
            //    foreach (var book in wantedBooks)
            //    {
            //        Console.WriteLine(book.Id);
            //    }
            //}



        }
    }
}
