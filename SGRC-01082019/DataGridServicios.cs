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
    public partial class DataGridServicios : Form
    {
        public DataGridServicios()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.MdiParent = MDI.ActiveForm; // I'm setting here MDI is the form parent
            obj.WindowState = FormWindowState.Maximized; //I'm setting here the home window will be maximized
            obj.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridServicios_Load(object sender, EventArgs e)
        {
            imp_data obj = new imp_data();
            obj.getAllServicios(dGridvServ);
        }
    }
}
