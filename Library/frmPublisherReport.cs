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
    public partial class frmPublisherReport : Form
    {
        private static frmPublisherReport _instance;
        public frmPublisherReport()
        {
            InitializeComponent();
            lstPublishers.DataSource = MockDatabase.Publishers.OrderBy(p => p.Name).ToList();
        }

        public static frmPublisherReport GetInstance()
        {
            if(_instance == null || _instance.IsDisposed)
            {
                _instance = new frmPublisherReport();
            }
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            List<Publisher> publisher = new List<Publisher>();
            try
            {
                publisher.Add(MockDatabase.FindPublisherById(Convert.ToInt64(txtCode.Text)));
                lstPublishers.DataSource = publisher;
            }
            catch (Exception)
            {
                lstPublishers.DataSource = MockDatabase.Publishers.OrderBy(p => p.Name).ToList();
            }
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                lstPublishers.DataSource = MockDatabase.FindPublisherByPartialName(txtName.Text);
            }
            catch (Exception)
            {
                lstPublishers.DataSource = MockDatabase.Publishers.OrderBy(p => p.Name).ToList();
            }
        }
    }
}
