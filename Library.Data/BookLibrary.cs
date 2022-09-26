using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class BookLibrary
    {

        public BookLibrary()
        {
            Load();
        }
        private List<Book> _books = new List<Book>(); //for private _ . We don't want anyone to change items, so private
        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Remove(Book book)
        {
            _books.Remove(book);
        }

        public IEnumerable<Book> Search(string query)
        {
            return _books.Where(b => b.Title.Contains(query, StringComparison.InvariantCultureIgnoreCase)); //.ToList(); //pridejom ToList, grazina kopija _books
            //return new List<Book>(); 
        }

        private void Load()
        {
            _books.Add(new Book("Test title")
            {
                Description = "Description",
                Rating = 3,
                Genre = GenreEnum.ScienceFiction,
                Authors = new List<Author>() { new Author("Nick") }.ToArray(),
                Keywords = new string[] { "Old", "England" }
            });
        }
    }
}
