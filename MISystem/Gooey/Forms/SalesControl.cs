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
    public partial class SalesControl : Form
    {
        public SalesControl()
        {
            InitializeComponent();
        }

        private void SalesControl_Load(object sender, EventArgs e)
        {
            //panelValidate.Visible = true;
            //panelValidate.Dock = DockStyle.Fill;
            //panelOrderCharts.Visible = false;

            panelValidate.Visible = false;
            panelOrderCharts.Visible = false;
            
        }

        private void guna2TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            panelOrderCharts.Visible = true;
            panelOrderCharts.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelOrderCharts.Visible = false;
        }


    }
}
