using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAddUser
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            login obj = new login();  //I'm setting here that my main screen will be the login form. Login is a child of this
            obj.MdiParent = this; // I'm setting here MDI is the form parent
            obj.WindowState = FormWindowState.Maximized; //I'm setting here the home window will be maximized
            obj.Show();
        }
    }
}
