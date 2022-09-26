using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    internal static class RemoveBookUIHelper
    {
        internal static void Start(BookLibrary bookLibrary)
        {
            var addBook = true;
            while (addBook)
            {
                Console.WriteLine("Please add book name, which you want to remove: ");
                var bookName = Console.ReadLine();
                var booksToDelete = bookLibrary.Search(bookName).ToList();
                if (booksToDelete.Count() > 0)
                {
                    foreach (var book in booksToDelete)
                    {
                        Console.WriteLine($"Deleting book {book.Title}");
                        bookLibrary.Remove(book);
                    }
                }
                else
                {
                    Console.WriteLine("No books found in this name");
                }
                Console.WriteLine("Do you want to remove another book? Y/N");
                var ifRemove = Console.ReadLine().ToUpper();
                if (ifRemove != "Y")
                {
                    addBook = false;
                }
            }
        }

    }
}
