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
    public partial class frmPublisherRegistration : Form
    {
        private static frmPublisherRegistration _instance;
        public frmPublisherRegistration()
        {
            InitializeComponent();
            txtCode.Text = Publisher.Coder.ToString();
        }

        public static frmPublisherRegistration GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmPublisherRegistration();
            }
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Name was not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Publisher p = new Publisher(txtName.Text);
                MockDatabase.Publishers.Add(p);
                MessageBox.Show("Publisher successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCode.Text = Publisher.Coder.ToString();
                txtName.Text = string.Empty;
            }
            txtName.Focus();
        }
    }
}
