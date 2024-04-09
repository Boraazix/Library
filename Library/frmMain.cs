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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
            frmBookReport.GetInstance().Show();
        }

        private void mnuPublisherReport_Click(object sender, EventArgs e)
        {
            frmPublisherReport.GetInstance().Show();
        }
    }
}
