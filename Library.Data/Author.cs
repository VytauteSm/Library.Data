using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class Author
    {
        public Author(string nickName) //constructor
        {
            NickName = nickName;
        }

        public Author(string name, string surname, string nickName = "") : this(nickName) //if not provided, will be empty
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public string NickName { get; set; }
    }
}
