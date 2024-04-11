using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmBookReport : Form
    {
        private static frmBookReport _instance;
        private static Author _author;
        private static Publisher _publisher;
        public frmBookReport()
        {
            InitializeComponent();

            if(_author != null && _publisher != null)
            {
                dgvMain.DataSource = MockDatabase.FindBooksByAuthorAndPublisher(_author.Code, _publisher.Code);
            }
            else if(_author != null)
            {
                dgvMain.DataSource = MockDatabase.FindBooksByAuthor(_author.Code);
            }
            else if(_publisher != null)
            {
                dgvMain.DataSource = MockDatabase.FindBooksByPublisher(_publisher.Code);
            }
            else
            {
                dgvMain.DataSource = MockDatabase.Books;
            }

            dgvMain.Columns[0].Width = 45;
            dgvMain.Columns[1].Width = 87;
            dgvMain.Columns[1].HeaderText = "ISBN";
            dgvMain.Columns[2].Width = 200;
            dgvMain.Columns[3].Width = 200;
            dgvMain.Columns[4].HeaderText = "Main author";
            dgvMain.Columns[5].Width = 130;
            dgvMain.Columns[6].Width = 75;
            dgvMain.Columns[6].DefaultCellStyle.Format = "yyyy'/'MM'/'dd";
            dgvMain.Columns[7].Width = 47;
            dgvMain.Columns[8].Width = 53;
            dgvMain.Columns[9].Width = 80;
            dgvMain.Columns[9].HeaderText = "New release";
        }

        public static frmBookReport GetInstance(Author author, Publisher publisher)
        {
            _author = author;
            _publisher = publisher;
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmBookReport();
            }
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }
    }
}
