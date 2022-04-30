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
    public partial class ProductInventoryTbl : Form
    {
        public ProductInventoryTbl()
        {
            InitializeComponent();
        }

        private void ProductInventoryTbl_Load(object sender, EventArgs e)
        {
            panelProdStats.Visible = true;
            panelProdStats.Dock = DockStyle.Fill;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ProductInventory addProd = new ProductInventory();
            addProd.Show();
        }

        private void btnProdGo_Click(object sender, EventArgs e)
        {
            panelProdStats.Visible = false;
        }
    }
}
