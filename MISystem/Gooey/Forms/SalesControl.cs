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
            panelProduct.Visible = false;
            panelCustomerDetail.Visible = false;
            panelPOSitem.Visible = true;
            panelPOSitem.Dock = DockStyle.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelPOSitem.Visible = false;
            panelProduct.Visible = true;
            panelCustomerDetail.Visible = true;
            
        }
    }
}
