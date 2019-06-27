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
    public partial class ABMConsorcistas : Form
    {
        public ABMConsorcistas()
        {
            InitializeComponent();
        }

        imp_data obj = new imp_data(); //Change it to Global
        reset_controls obj1 = new reset_controls(); 

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.MdiParent = MDI.ActiveForm; // I'm setting here MDI is the form parent
            obj.WindowState = FormWindowState.Maximized; //I'm setting here the home window will be maximized
            obj.Show();
        }

        private void SearchConsorcioBtn_Click(object sender, EventArgs e)
        {
            if (CuitConsorcio1Txt.Text != "")
            {
                string[] ConsorcioData = obj.GetConsorcio(CuitConsorcio1Txt.Text);
                NameConsorcio1Txt.Text = ConsorcioData[0];
                DomConsorcistaTxt.Text = ConsorcioData[1];
                ConsorcistaCpTxt.Text = ConsorcioData[2];
            }
            else
            {
                MessageBox.Show("Please enter Consorcio CUIT number");
            }
        }

        private void AltaBtn_Click(object sender, EventArgs e)
        {
            imp_data obj = new imp_data();  //we creaTe an object from our imp_data class
            DialogResult dr = MessageBox.Show("Do you want to add this Consorcista?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                obj.AddConsorcista(CuitConsorcio1Txt.Text, nameConsorcistaTxt.Text, NameConsorcio1Txt.Text, DomConsorcistaTxt.Text,
                    phoneConsorcistaTxt.Text, emailConsorcistaTxt.Text, Convert.ToInt32(ConsorcistaCpTxt.Text), Convert.ToInt32(UFNumberTxt.Text),
                    fdTxt.Text, Convert.ToDecimal(expenPorTxt.Text));
            }
        }

        private void SearchConsorcistaBtn_Click(object sender, EventArgs e)
        {
            if (nameConsorcistaTxt.Text.Trim() != "")
            {
                string[] ConsorcistaData = obj.GetConsorcista(nameConsorcistaTxt.Text);
                CuitConsorcio1Txt.Text = ConsorcistaData[0];
                nameConsorcistaTxt.Text = ConsorcistaData[1];
                NameConsorcio1Txt.Text = ConsorcistaData[2];
                DomConsorcistaTxt.Text = ConsorcistaData[3];
                phoneConsorcistaTxt.Text = ConsorcistaData[4];
                emailConsorcistaTxt.Text = ConsorcistaData[5];
                ConsorcistaCpTxt.Text = ConsorcistaData[6];
                UFNumberTxt.Text = ConsorcistaData[7];
                fdTxt.Text = ConsorcistaData[8];
                expenPorTxt.Text = ConsorcistaData[9];
            }
            else
            {
                MessageBox.Show("Please enter a correct Consorcista name");
            }
        }
        private void Clean1Btn_Click(object sender, EventArgs e)
        {
            obj1.reset(panel_consorcista);
        }

        private void CuitConsorcio1Txt_TextChanged(object sender, EventArgs e)
        {
            if (CuitConsorcio1Txt.Text == "")
            {
                CuitConsorcio1Txt.BackColor = Color.Firebrick;
            }
            else
            {
                CuitConsorcio1Txt.BackColor = Color.White;
            }

        }

        private void NameConsorcistaTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameConsorcistaTxt.Text == "")
            {
                nameConsorcistaTxt.BackColor = Color.Firebrick;
            }
            else
            {
                nameConsorcistaTxt.BackColor = Color.White;
            }
        }

        private void NameConsorcio1Txt_TextChanged(object sender, EventArgs e)
        {
            if (NameConsorcio1Txt.Text == "")
            {
                NameConsorcio1Txt.BackColor = Color.Firebrick;
            }
            else
            {
                NameConsorcio1Txt.BackColor = Color.White;
            }
        }

        private void DomConsorcistaTxt_TextChanged(object sender, EventArgs e)
        {
            if (DomConsorcistaTxt.Text == "")
            {
                DomConsorcistaTxt.BackColor = Color.Firebrick;
            }
            else
            {
                DomConsorcistaTxt.BackColor = Color.White;
            }
        }

        private void PhoneConsorcistaTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneConsorcistaTxt.Text == "")
            {
                phoneConsorcistaTxt.BackColor = Color.Firebrick;
            }
            else
            {
                phoneConsorcistaTxt.BackColor = Color.White;
            }
        }

        private void EmailConsorcistaTxt_TextChanged(object sender, EventArgs e)
        {
            if (emailConsorcistaTxt.Text == "")
            {
                emailConsorcistaTxt.BackColor = Color.Firebrick;
            }
            else
            {
                emailConsorcistaTxt.BackColor = Color.White;
            }
        }

        private void ConsorcistaCpTxt_TextChanged(object sender, EventArgs e)
        {
            if (ConsorcistaCpTxt.Text == "")
            {
                ConsorcistaCpTxt.BackColor = Color.Firebrick;
            }
            else
            {
                ConsorcistaCpTxt.BackColor = Color.White;
            }
        }

        private void UFNumberTxt_TextChanged(object sender, EventArgs e)
        {
            if(UFNumberTxt.Text == "")
            {
                UFNumberTxt.BackColor = Color.Firebrick;
            }
            else
            {
                UFNumberTxt.BackColor = Color.White;
            }
        }

        private void FdTxt_TextChanged(object sender, EventArgs e)
        {
            if (fdTxt.Text == "")
            {
                fdTxt.BackColor = Color.Firebrick;
            }
            else
            {
                fdTxt.BackColor = Color.White;
            }
        }

        private void ExpenPorTxt_TextChanged(object sender, EventArgs e)
        {
            if (expenPorTxt.Text == "")
            {
                expenPorTxt.BackColor = Color.Firebrick;
            }
            else
            {
                expenPorTxt.BackColor = Color.White;
            }
        }

        private void ABMConsorcistas_Load(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
