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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        imp_data obj = new imp_data();
       

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (user_nameTxt.Text != "")
            {
                //string[] UserData = obj.GetUser(user_nameTxt.Text, user_passTxt.Text);
                bool userSuccess = obj.GetUser(user_nameTxt.Text.Trim(), user_passTxt.Text.Trim()); //we use Trim() to remove white-spaces
                //if (user_nameTxt.Text == UserData[1] && user_passTxt.Text == UserData[2]) {
                if (userSuccess == true){
                    this.Hide();  //this is to use the current object/form
                    Home obj = new Home();
                    obj.MdiParent = MDI.ActiveForm;  // I'm setting here MDI is the parent
                    obj.WindowState = FormWindowState.Maximized;
                    obj.Show();

                }
                else
                {
                    MessageBox.Show("User name or password incorrect. Please check again");

                }

            }
            else
            {
                MessageBox.Show("Please complete all data");
            }
        }
    }
}
