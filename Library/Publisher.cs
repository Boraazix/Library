using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Publisher
    {
        public static Int64 Coder { get; private set; }
        public Int64 Code { get; private set; }
        public String Name { get; set; }

        static Publisher()
        {
            Coder = 1;
        }

        public Publisher()
        {
            Code = Coder++;
            Name = "Unnamed";
        }

        public Publisher(String name) : this()
        {
            Name = name;
        }

        public override string ToString()
        {
            return Code + " | " + Name;
        }
    }
}
