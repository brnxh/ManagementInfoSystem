using MISystem.Gooey.Forms.Dialog;
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
    public partial class CustomerManage : Form
    {
        public CustomerManage()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Please enter your credentials first!", "Enter Credentials");

            if (result == DialogResult.OK)
            {
                new confirmAccess().ShowDialog();
            }

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
