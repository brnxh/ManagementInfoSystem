using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MISystem.Gooey.Forms
{
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cbDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDrop.SelectedItem == "Admin" || cbDrop.SelectedItem == "Operator")
            {
                lblUser.Visible = true;
                tbUser.Visible = true;
                lblPass.Visible = true;
                tbPass.Visible = true;
            }
            else
            {
                lblUser.Visible = false;
                tbUser.Visible = false;
                lblPass.Visible = false;
                tbPass.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
