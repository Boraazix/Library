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
    public partial class frmBookRegistration : Form
    {
        private static frmBookRegistration _instance;
        private static List<Int64> _selectedAuthors = new List<Int64>();
        private static ListBox _clickedListBox = new ListBox();
        public frmBookRegistration()
        {
            InitializeComponent();
            lstAuthors.DataSource = MockDatabase.Authors.OrderBy(a => a.Name).ToList();
            cmbPublishers.DataSource = MockDatabase.Publishers.OrderBy(p => p.Name).ToList();
            txtCode.Text = Book.Coder.ToString();
        }

        public static frmBookRegistration GetInstance()
        {
            if(_instance == null || _instance.IsDisposed)
            {
                _instance = new frmBookRegistration();
            }
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAuthor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                lstAuthors.DataSource = MockDatabase.FindAuthorByPartialName(txtAuthor.Text);
            }
            catch (Exception)
            {
                lstAuthors.DataSource = MockDatabase.Authors.OrderBy(a => a.Name).ToList();
            }
        }


        private void lstAll_MouseDown(object sender, MouseEventArgs e)
        {
            _clickedListBox = (ListBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                var listBox = (ListBox)sender;
                if (listBox.SelectedItem != null)
                {
                    listBox.DoDragDrop(listBox.SelectedItem, DragDropEffects.Move);
                }
            }
        }

        private void lstAll_DragDrop(object sender, DragEventArgs e)
        {
            var listBox = (ListBox)sender;
            Author author = (Author)e.Data.GetData(typeof(Author));

            if (listBox == lstSelectedAuthors && !_selectedAuthors.Contains(author.Code))
            {
                _selectedAuthors.Add(author.Code);
                lstSelectedAuthors.DataSource = MockDatabase.FindAuthorByCodeList(_selectedAuthors);
            } else
            if (listBox == lstAuthors && _clickedListBox == lstSelectedAuthors)
            {
                _selectedAuthors.Remove(author.Code);
                lstSelectedAuthors.DataSource = MockDatabase.FindAuthorByCodeList(_selectedAuthors);
            }


        }

        private void lstAll_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void frmBookRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            _selectedAuthors.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtIsbn.Text.Length == 0)
            { MessageBox.Show("ISBN was not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtIsbn.Focus(); }
            else if (txtTitle.Text.Length == 0)
            { MessageBox.Show("Title was not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtTitle.Focus(); }
            else if (txtDescription.Text.Length == 0)
            { MessageBox.Show("Description was not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtDescription.Focus(); }
            else if (_selectedAuthors.Count == 0)
            { MessageBox.Show("No auhtor was selected!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtAuthor.Focus(); }
            else if (cmbPublishers.SelectedIndex == -1)
            { MessageBox.Show("Publisher was not selected!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); cmbPublishers.Focus(); }
            else
            {
                Book book = new Book(Int64.Parse(txtIsbn.Text), txtTitle.Text, txtDescription.Text, MockDatabase.FindAuthorByCodeList(_selectedAuthors), (Publisher)cmbPublishers.SelectedItem, dtpPublication.Value, Int16.Parse(nudPages.Value.ToString()), Int16.Parse(nudEdition.Value.ToString()), chkRelease.Checked);
                MockDatabase.Books.Add(book);
                MockDatabase.SetBookToAuthors(book.Code, _selectedAuthors);
                MessageBox.Show("Book successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIsbn.Text = ""; txtTitle.Text = ""; txtDescription.Text = ""; txtAuthor.Text = "";
                lstAuthors.DataSource = MockDatabase.Authors.OrderBy(a => a.Name).ToList();
                _selectedAuthors.Clear(); lstSelectedAuthors.DataSource = new List<Author> { }; dtpPublication.Value = DateTime.Now;
                nudPages.Value = 0; nudEdition.Value = 0; chkRelease.Checked = false;
            }
        }
    }
}
