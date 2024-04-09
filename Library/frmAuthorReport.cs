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
    public partial class frmAuthorReport : Form
    {
        private static frmAuthorReport _instance;
        public frmAuthorReport()
        {
            InitializeComponent();
            lstAuthors.DataSource = MockDatabase.Authors.OrderBy(a => a.Name).ToList();
        }

        public static frmAuthorReport GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmAuthorReport();
            }
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            List<Author> author = new List<Author>();
            try
            {
                author.Add(MockDatabase.FindAuthorById(Convert.ToInt64(txtCode.Text)));
                lstAuthors.DataSource = author;
            }
            catch (Exception)
            {
                lstAuthors.DataSource = MockDatabase.Authors.OrderBy(a => a.Name).ToList();
            }
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                lstAuthors.DataSource = MockDatabase.FindAuthorByPartialName(txtName.Text);
            }
            catch (Exception)
            {
                lstAuthors.DataSource = MockDatabase.Authors.OrderBy(a => a.Name).ToList();
            }
        }
    }
}
