using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Author
    {
        public static Int64 Coder { get; private set; }
        public Int64 Code { get; private set; }
        public String Name { get; set; }
        public List<Book> Books { get; set; }

        static Author()
        {
            Coder = 1;
        }

        public Author() 
        {
            Name = "Unnamed";
            Books = new List<Book>();
        }

        public Author(String name) : this()
        {
            Code = Coder++;
            Name = name;
        }

        public override string ToString()
        {
            return Code + " | " + Name + ", " + Books.Count() + " book(s) registered.";
        }
    }
}
