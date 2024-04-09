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
    public partial class frmBookRegistration : Form
    {
        private static frmBookRegistration _instance;
        public frmBookRegistration()
        {
            InitializeComponent();
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

    }
}
