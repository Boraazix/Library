using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            Author a = new Author("Obama Agora Conquista");
            MockDatabase.Authors.Add(a);
            Author b = new Author("Ayrton");
            MockDatabase.Authors.Add(b);

            Publisher p = new Publisher("Senna");
            MockDatabase.Publishers.Add(p);
            Publisher q = new Publisher("Care Productions ltda");
            MockDatabase.Publishers.Add(q);

            Book book = new Book(1234567890123, "A mérito", "Esse é sem dúvida um dos livros já feitos.", new List<Author> {a, b}, p, DateTime.Now, 500, 3, true);
            MockDatabase.Books.Add(book);
            MockDatabase.SetBookToAuthors(book.Code, new List<Int64> { a.Code, b.Code });

            Book bo = new Book(1234567890124, "A mérito do cara ali dios masmorra", "Esse é sem dúvida um dos livros já feitos.", new List<Author> { b }, q, DateTime.Now, 499, 5, false);
            MockDatabase.Books.Add(bo);
            MockDatabase.SetBookToAuthors(bo.Code, new List<Int64> { b.Code });
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAuthorRegistration_Click(object sender, EventArgs e)
        {
            frmAuthorRegistration.GetInstance().Show();
        }

        private void mnuBookRegistration_Click(object sender, EventArgs e)
        {
            frmBookRegistration.GetInstance().Show();
        }


        private void mnuPublisherRegistration_Click(object sender, EventArgs e)
        {
            frmPublisherRegistration.GetInstance().Show();
        }

        private void mnuAuthorReport_Click(object sender, EventArgs e)
        {
            frmAuthorReport.GetInstance().Show();
        }

        private void mnuBookReport_Click(object sender, EventArgs e)
        {
            frmBookFilterReport.GetInstance().Show();
        }

        private void mnuPublisherReport_Click(object sender, EventArgs e)
        {
            frmPublisherReport.GetInstance().Show();
        }
    }
}
