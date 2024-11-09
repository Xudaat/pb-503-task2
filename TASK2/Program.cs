namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Library library = new Library();


                Book book1 = new Book(1, "Yuz illik tenha", 29m, 5, "Tarixi roman");
                Book book2 = new Book(2, "Qurur ve Qerez", 25m, 10, "Klassik edebiyyat");
                Book book3 = new Book(3, "Cinayet ve Ceza", 15m, 2, "Psixoloji roman");


                library.AddBook(book1);
                library.AddBook(book2);
                library.AddBook(book3);


                Console.WriteLine("GetBookById(2):");
                var foundBookById = library.GetBookById(2);
                if (foundBookById != null)
                {
                    Console.WriteLine(foundBookById);
                }
                else
                {
                    Console.WriteLine("Book not found!");
                }
                Console.WriteLine();


                Console.WriteLine("GetBookByName('Qurur ve Qerez'):");
                var foundBookByName = library.GetBookByName("Qurur ve Qerez");
                if (foundBookByName != null)
                {
                    Console.WriteLine(foundBookByName);
                }
                else
                {
                    Console.WriteLine("Book not found!");
                }
                Console.WriteLine();


                Console.WriteLine("GetFilteredBooks('Klassik edebiyyat'):");
                var programmingBooks = library.GetFilteredBooks("Klassik edebiyyat");
                foreach (var book in programmingBooks)
                {
                    Console.WriteLine(book);
                }
                Console.WriteLine();


                Console.WriteLine("GetFilteredBooks(20, 30):");
                var booksInPriceRange = library.GetFilteredBooks(20, 30);
                foreach (var book in booksInPriceRange)
                {
                    Console.WriteLine(book);
                }
        }
    }
}
    


