using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class MockDatabase
    {
        public static List<Author> Authors { get; set; }
        public static List<Publisher> Publishers { get; set; }
        public static List<Book> Books { get;  set; }

        static MockDatabase()
        {
            Authors= new List<Author>();
            Publishers= new List<Publisher>();
            Books= new List<Book>();
        }
        public static Book FindBookById(Int64 c)
        {
            foreach (Book b in Books)
            {
                if (b.Code == c)
                    return b;
            }
            return null;
        }
        public static Author FindAuthorById(Int64 c)
        {
            foreach (Author a in Authors)
            {
                if (a.Code == c)
                    return a;
            }
            return null;
        }
        public static List<Author> FindAuthorByPartialName(String n)
        {
            List<Author> authors = new List<Author>();
            foreach (Author a in Authors)
            {
                if(a.Name.ToUpper().Contains(n.ToUpper()))
                {
                    authors.Add(a);
                }
            }
            return authors;
        }
        public static List<Author> FindAuthorByCodeList(List<Int64> c)
        {
            List<Author> authors = new List<Author>();
            foreach (Int64 i in c)
            {
                authors.Add(FindAuthorById(i));
            }
            return authors;
        }
        public static Publisher FindPublisherById(Int64 c)
        {
            foreach (Publisher p in Publishers)
            {
                if (p.Code == c)
                    return p;
            }
            return null;
        }
        public static List<Publisher> FindPublisherByPartialName(String n)
        {
            List<Publisher> publishers = new List<Publisher>();
            foreach (Publisher p in Publishers)
            {
                if (p.Name.ToUpper().Contains(n.ToUpper()))
                {
                    publishers.Add(p);
                }
            }
            return publishers;
        }
    }
}
