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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(tbCheckPass.Text == "password")
            {
                panelChangePass.Visible = true;
            }
            else
            {
                MessageBox.Show("Try again!", "Change Password");
            }
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            panelChangePass.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
