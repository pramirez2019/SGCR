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
    public partial class ABMServicios : Form
    {
        public ABMServicios()
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

        private void SearchCategBtn_Click(object sender, EventArgs e)
        {
            if (idcategTxt.Text != "")
            {
                string[] CategoriaData = obj.GetCategoria(Convert.ToInt32(idcategTxt.Text));
                idcategTxt.Text = CategoriaData[0];
                namecategTxt.Text = CategoriaData[1];
            }
            else
            {
                MessageBox.Show("Please enter Categoría number");
            }
        }

      
        private void CleanBtn_Click_1(object sender, EventArgs e)
        {
            obj1.reset(panel_servicios);
        }

        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.MdiParent = MDI.ActiveForm; // I'm setting here MDI is the form parent
            obj.WindowState = FormWindowState.Maximized; //I'm setting here the home window will be maximized
            obj.Show();
        }

        private void AltaServBtn_Click(object sender, EventArgs e)
        {
            imp_data obj = new imp_data();  //we creaTe an object from our imp_data class
            DialogResult dr = MessageBox.Show("Do you want to add this Servicio?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                obj.AddServicio(Convert.ToInt32(idcategTxt.Text), CuitservicioTxt.Text, nameservicioTxt.Text, DomServicioTxt.Text,
                    phoneServicioTxt.Text, emailServicioTxt.Text);
            }
        }

        private void SearchCategBtn_Click_1(object sender, EventArgs e)
        {
            if (idcategTxt.Text != "")
            {
                string[] CategoriaData = obj.GetCategoria(Convert.ToInt32(idcategTxt.Text));
                idcategTxt.Text = CategoriaData[0];
                namecategTxt.Text = CategoriaData[1];
            }
            else
            {
                MessageBox.Show("Please enter Categoría number");
            }
        }

        private void SearchServbtn_Click(object sender, EventArgs e)
        {
            if (nameservicioTxt.Text.Trim() != "")
            {
                string[] ServicioData = obj.GetServicio(nameservicioTxt.Text);
                idcategTxt.Text = ServicioData[0];
                CuitservicioTxt.Text = ServicioData[1];
                nameservicioTxt.Text = ServicioData[2];
                DomServicioTxt.Text = ServicioData[3];
                phoneServicioTxt.Text = ServicioData[4];
                emailServicioTxt.Text = ServicioData[5];              
            }
            else
            {
                MessageBox.Show("Please enter a correct Servicio name");
            }
        }

        private void UptServBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to modify this Servicio?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                obj.UpdateServicio(Convert.ToInt32(idcategTxt.Text), CuitservicioTxt.Text, nameservicioTxt.Text, DomServicioTxt.Text,
                    phoneServicioTxt.Text, emailServicioTxt.Text);
            }
        }
        private void DelServBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete this Servicio?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                obj.DeleteServicio(CuitservicioTxt.Text);
                obj1.reset(panel_servicios);
            }
        }
        private void IdcategTxt_TextChanged(object sender, EventArgs e)
        {
            if (idcategTxt.Text == "")
            {
                idcategTxt.BackColor = Color.Firebrick;
            }
            else
            {
                idcategTxt.BackColor = Color.White;
            }
        }

        private void NamecategTxt_TextChanged(object sender, EventArgs e)
        {
            if (namecategTxt.Text == "")
            {
                namecategTxt.BackColor = Color.Firebrick;
            }
            else
            {
                namecategTxt.BackColor = Color.White;
            }
        }

        private void CuitservicioTxt_TextChanged(object sender, EventArgs e)
        {
            if(CuitservicioTxt.Text == "")
            {
                CuitservicioTxt.BackColor = Color.Firebrick;
            }
            else
            {
                CuitservicioTxt.BackColor = Color.White;
            }
        }

        private void NameservicioTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameservicioTxt.Text == "")
            {
                nameservicioTxt.BackColor = Color.Firebrick;
            }
            else
            {
                nameservicioTxt.BackColor = Color.White;
            }
        }

        private void DomServicioTxt_TextChanged(object sender, EventArgs e)
        {
            if (DomServicioTxt.Text == "")
            {
                DomServicioTxt.BackColor = Color.Firebrick;
            }
            else
            {
                DomServicioTxt.BackColor = Color.White;
            }
        }

        private void PhoneServicioTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneServicioTxt.Text == "")
            {
                phoneServicioTxt.BackColor = Color.Firebrick;
            }
            else
            {
                phoneServicioTxt.BackColor = Color.White;
            }
        }

        private void EmailServicioTxt_TextChanged(object sender, EventArgs e)
        {
            if (emailServicioTxt.Text == "")
            {
                emailServicioTxt.BackColor = Color.Firebrick;
            }
            else
            {
                emailServicioTxt.BackColor = Color.White;
            }
        }

        
    }
}
