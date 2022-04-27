using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MISystem.Gooey.Forms.Dialog
{
    public partial class confirmAccess : Form
    {
        public confirmAccess()
        {
            InitializeComponent();
        }

        private void confirmAccess_Load(object sender, EventArgs e)
        {
            

            }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if(tbUser.Text == "pogi" && tbPass.Text == "pogi")
            {
                // kelangan lumabas yung customerManage
            }
            else
            {
                MessageBox.Show("Higher authentication needed!");
            }

            this.Hide();
        }
    }
}
