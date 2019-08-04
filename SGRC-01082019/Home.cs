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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AddConsorcioBtn_Click(object sender, EventArgs e)
        {
            this.Close();  //this is to use the current object/form
            ABMConsorcio obj = new ABMConsorcio();
            obj.MdiParent = MDI.ActiveForm;  // I'm setting here MDI is the parent
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
                }

        private void abmconsorcioBtn_Click(object sender, EventArgs e)
        {
            this.Close();  //this is to use the current object/form
            ABMConsorcio obj = new ABMConsorcio();
            obj.MdiParent = MDI.ActiveForm;  // I'm setting here MDI is the parent
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
             this.clocklabel.Text = DateTime.Now.ToString();  //Use timer from components
            
        }

        private void AbmBtn_Click(object sender, EventArgs e)
        {
            this.Close();  //this is to use the current object/form
            ABMConsorcistas obj = new ABMConsorcistas();
            obj.MdiParent = MDI.ActiveForm;  // I'm setting here MDI is the parent
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void CategBtn_Click(object sender, EventArgs e)
        {
            this.Close();  //this is to use the current object/form
            ABMCategorias obj = new ABMCategorias();
            obj.MdiParent = MDI.ActiveForm;  // I'm setting here MDI is the parent
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void ServBtn_Click(object sender, EventArgs e)
        {
            this.Close();  //this is to use the current object/form
            ABMServicios obj = new ABMServicios();
            obj.MdiParent = MDI.ActiveForm;  // I'm setting here MDI is the parent
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void ViewServbtn_Click(object sender, EventArgs e)
        {
            this.Close();  //this is to use the current object/form
            DataGridServicios obj = new DataGridServicios(); //this is a form
            obj.MdiParent = MDI.ActiveForm;  // I'm setting here MDI is the parent
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }
    }
}
