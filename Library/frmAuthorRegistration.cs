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
    public partial class frmAuthorRegistration : Form
    {
        private static frmAuthorRegistration _instance;

        public frmAuthorRegistration()
        {
            InitializeComponent();
            txtCode.Text = Author.Coder.ToString();
        }

        public static frmAuthorRegistration GetInstance()
        {
            if(_instance == null || _instance.IsDisposed)
            {
                _instance = new frmAuthorRegistration();
            }
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length == 0) 
            {
                MessageBox.Show("Name was not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Author a = new Author(txtName.Text);
                MockDatabase.Authors.Add(a);
                MessageBox.Show("Author successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCode.Text = Author.Coder.ToString();
                txtName.Text = string.Empty;
            }
            txtName.Focus();
        }
    }
}
