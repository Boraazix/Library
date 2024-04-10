using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public static Int64 Coder { get; private set; }
        public Int64 Code { get; private set; }
        public Int64 Isbn { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public List<Author> Authors { get; set; }
        public Publisher Publisher { get; set; }
        public DateTime Publication { get; set; }
        public short Pages { get; set; }
        public short Edition { get; set; }
        public Boolean Release { get; set; }

        static Book()
        {
            Coder = 1;
        }

        public Book()
        {
            Code = Coder++;
            Title = "Untitled";
            Description = "Without description";
            Authors = new List<Author>();
            Publisher = new Publisher();
        }

        public Book(Int64 isbn, string title, string description, List<Author> authors, Publisher publishingCompany, DateTime publication, short pages, short edition, Boolean release) : this()
        {
            Isbn = isbn;
            Title = title;
            Description = description;
            Authors = authors;
            Publisher = publishingCompany;
            Publication = publication;
            Pages = pages;
            Edition = edition;
            Release = release;
        }

        public override string ToString()
        {
            return Code + " | "+ Title + " | " + Publisher.Name;
        }
    }
}
