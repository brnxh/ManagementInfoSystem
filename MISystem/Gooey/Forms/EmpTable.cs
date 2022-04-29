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
    public partial class EmpTable : Form
    {
        public EmpTable()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ManageEmployees addEmp = new ManageEmployees();
            addEmp.Show();
        }

        private void EmpTable_Load(object sender, EventArgs e)
        {

        }
    }
}
