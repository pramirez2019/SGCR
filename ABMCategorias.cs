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
    public partial class ABMCategorias : Form
    {
        public ABMCategorias()
        {
            InitializeComponent();
        }
        imp_data obj = new imp_data(); // I create the obj globally to avoid to repeat the operation
        reset_controls obj1 = new reset_controls(); // I create the ob1 globally to call the method later.
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.MdiParent = MDI.ActiveForm; // I'm setting here MDI is the form parent
            obj.WindowState = FormWindowState.Maximized; //I'm setting here the home window will be maximized
            obj.Show();
        }

        private void AltaCategBtn_Click(object sender, EventArgs e)
        {
            imp_data obj = new imp_data();  //we creaTe an object from our imp_data class
            DialogResult dr = MessageBox.Show("Do you want to add this Categoría?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                obj.AddCategRubro(Convert.ToInt32(idcategTxt.Text), namecategTxt.Text, descripcategTxt.Text);
            }
        }

        private void SearchCategBtn_Click(object sender, EventArgs e)
        {
            if (idcategTxt.Text != "")
            {
                string[] CategoriaData = obj.GetCategoria(Convert.ToInt32(idcategTxt.Text));
                idcategTxt.Text = CategoriaData[0];
                namecategTxt.Text = CategoriaData[1];
                descripcategTxt.Text = CategoriaData[2];
            }
            else
            {
                MessageBox.Show("Please enter Categoría number");
            }
        }

        private void CleanBtn_Click(object sender, EventArgs e)
        {
            obj1.reset(panel_categoria);
        }
    }
}
