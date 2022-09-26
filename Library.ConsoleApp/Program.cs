using Library.Data;

namespace Library.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookLibrary = new BookLibrary();

            //bookLibrary.Add(new Book("Test"));
            //bookLibrary.Add(new Book("Test1"));
            //bookLibrary.Add(new Book("Test2"));
            //bookLibrary.Add(new Book("Test3"));
            //bookLibrary.Add(new Book("Test4"));
            //bookLibrary.Add(new Book("Hamlet"));

            //var books = bookLibrary.Search("Test");

            //foreach (var item in books)
            //{
            //    Console.WriteLine(item);
            //}

            while (true)
            {
                var menuSelection = Menu.GetUserMenuSelection();

                switch (menuSelection)
                {
                    case "A":
                        AddBookUIHelper.Start(bookLibrary);
                        break;
                    case "R":
                        RemoveBookUIHelper.Start(bookLibrary);              
                        break;
                    case "S":
                        break;
                    case "E":
                        return;
                }
            }
        }
    }
}