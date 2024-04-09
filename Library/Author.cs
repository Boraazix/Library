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

        static Author()
        {
            Coder = 1;
        }

        public Author() 
        {
            Code = Coder++;
            Name = "Unnamed";
        }

        public Author(String name) : this()
        {
            Name = name;
        }

        public override string ToString()
        {
            return Code + " | " + Name;
        }
    }
}
