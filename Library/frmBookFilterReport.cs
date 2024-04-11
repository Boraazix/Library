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
    public partial class frmBookFilterReport : Form
    {
        private static frmBookFilterReport _instance;
        public frmBookFilterReport()
        {
            InitializeComponent();
            lstAuthors.DataSource = MockDatabase.Authors.OrderBy(a => a.Name).ToList();
            lstPublishers.DataSource = MockDatabase.Publishers.OrderBy(p => p.Name).ToList();
        }

        public static frmBookFilterReport GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmBookFilterReport();
            }
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void txtAuthor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                lstAuthors.DataSource = MockDatabase.FindAuthorByPartialName(txtAuthor.Text).OrderBy(a => a.Name).ToList();
            }
            catch (Exception)
            {
                lstAuthors.DataSource = MockDatabase.Authors.OrderBy(a => a.Name).ToList();
            }
        }

        private void txtPublisher_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                lstPublishers.DataSource = MockDatabase.FindPublisherByPartialName(txtPublisher.Text).OrderBy(p => p.Name).ToList();
            }
            catch (Exception)
            {
                lstPublishers.DataSource = MockDatabase.Publishers.OrderBy(p => p.Name).ToList();
            }
        }

        private void chkAllAuthors_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllAuthors.Checked)
            {
                txtAuthor.Enabled = false;
                lstAuthors.Enabled = false;
            }
            else
            {
                txtAuthor.Enabled = true;
                lstAuthors.Enabled = true;
            }
        }

        private void chkAllPublishers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllPublishers.Checked)
            {
                txtPublisher.Enabled = false;
                lstPublishers.Enabled = false;
            }
            else
            {
                txtPublisher.Enabled = true;
                lstPublishers.Enabled = true;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (lstAuthors.SelectedIndex == -1 && !chkAllAuthors.Checked)
            {
                MessageBox.Show("Author was not selected!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (lstPublishers.SelectedIndex == -1 && !chkAllPublishers.Checked)
            {
                MessageBox.Show("Publisher was not selected!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmBookReport.GetInstance((chkAllAuthors.Checked ? null : (Author)lstAuthors.SelectedItem), (chkAllPublishers.Checked ? null : (Publisher)lstPublishers.SelectedItem)).Show();
            }
        }
    }
}
