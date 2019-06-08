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
    public partial class ABMConsorcio : Form
    {
        public ABMConsorcio()
        {
            InitializeComponent();
        }

        imp_data obj = new imp_data(); // I create the obj globally to avoid to repeat the operation
        reset_controls obj1 = new reset_controls(); // I create the ob1 globally to call the method later.
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (CuitConsorcioTxt.Text !="")
            {
                string[] ConsorcioData = obj.GetConsorcio(CuitConsorcioTxt.Text);
                NameConsorcioTxt.Text = ConsorcioData[0];
                DomConsorcioTxt.Text = ConsorcioData[1];
                ConsorcioCpTxt.Text = ConsorcioData[2];
                CategConsorcioTxt.Text = ConsorcioData[3];
                SuthernConsorcioTxt.Text = ConsorcioData[4];
                StatusConsorcioTxt.Text = ConsorcioData[5];
            }
            else
            {
                MessageBox.Show("Please enter CUIT number");
            }
        }

        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.MdiParent = MDI.ActiveForm; // I'm setting here MDI is the form parent
            obj.WindowState = FormWindowState.Maximized; //I'm setting here the home window will be maximized
            obj.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to modify this Consorcio?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                obj.UpdateConsorcio(NameConsorcioTxt.Text, DomConsorcioTxt.Text, Convert.ToInt32(ConsorcioCpTxt.Text), CuitConsorcioTxt.Text, CategConsorcioTxt.Text, SuthernConsorcioTxt.Text, StatusConsorcioTxt.Text);
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete this Consorcio?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                obj.DeleteConsorcio(CuitConsorcioTxt.Text);
            }
        }

        private void altaBtn_Click(object sender, EventArgs e)
        {
            imp_data obj = new imp_data();  //we creaTe an objecti from our imp_data class
            DialogResult dr = MessageBox.Show("Do you want to add this Consorcio?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                obj.AddConsorcio(NameConsorcioTxt.Text, DomConsorcioTxt.Text, Convert.ToInt32(ConsorcioCpTxt.Text), CuitConsorcioTxt.Text, CategConsorcioTxt.Text, SuthernConsorcioTxt.Text, StatusConsorcioTxt.Text);
            }
        }

        private void AltaBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void CuitConsorcioTxt_TextChanged(object sender, EventArgs e)
        {
            if (CuitConsorcioTxt.Text == "")
            {
                CuitConsorcioTxt.BackColor = Color.Firebrick;
            }
            else
            {
                CuitConsorcioTxt.BackColor = Color.White;
            }
        }

        private void NameConsorcioTxt_TextChanged(object sender, EventArgs e)
        {
            if (NameConsorcioTxt.Text == "") { NameConsorcioTxt.BackColor = Color.Firebrick; } else { NameConsorcioTxt.BackColor = Color.White; }
        }

        private void DomConsorcioTxt_TextChanged(object sender, EventArgs e)
        {
            if (DomConsorcioTxt.Text == "") { DomConsorcioTxt.BackColor = Color.Firebrick; } else { DomConsorcioTxt.BackColor = Color.White; }
        }

        private void ConsorcioCpTxt_TextChanged(object sender, EventArgs e)
        {
            if (ConsorcioCpTxt.Text == "")
            {
                ConsorcioCpTxt.BackColor = Color.Firebrick;
            }
            else
            {
                ConsorcioCpTxt.BackColor = Color.White;
            }

        }

        private void CategConsorcioTxt_TextChanged(object sender, EventArgs e)
        {
            if (CategConsorcioTxt.Text == "")
            {
                CategConsorcioTxt.BackColor = Color.Firebrick;
            }
            else
            {
                CategConsorcioTxt.BackColor = Color.White;
            }

        }

        private void SuthernConsorcioTxt_TextChanged(object sender, EventArgs e)
        {
            if (SuthernConsorcioTxt.Text == "")
            {
                SuthernConsorcioTxt.BackColor = Color.Firebrick;
            }
            else
            {
                SuthernConsorcioTxt.BackColor = Color.White;
            }
        }

        private void StatusConsorcioTxt_TextChanged(object sender, EventArgs e)
        {
            if (StatusConsorcioTxt.Text == "")
            {
                StatusConsorcioTxt.BackColor = Color.Firebrick;
            }
            else
            {
                StatusConsorcioTxt.BackColor = Color.White;
            }
        }

        private void CleanBtn_Click(object sender, EventArgs e)
        {
            obj1.reset(panel_consorcio);
        }

    }
}
