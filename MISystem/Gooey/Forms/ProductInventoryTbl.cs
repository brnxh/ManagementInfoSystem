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
            
            panelValidate.Visible = false;
            //panelValidate.Dock = DockStyle.Fill;

            panelAddProd.Visible = false;
            //panelAddProd.Dock = DockStyle.Fill;

            panelProdStats.Visible = true;
            panelProdStats.Dock = DockStyle.Fill;

            panelProdInv.Visible = false;
            //panelProdInv.Dock = DockStyle.Fill;
            //panelValidate.Visible = false;
            //panelProdStats.Visible = true;
            //panelProdStats.Dock = DockStyle.Fill;
        }

        private void btnProdGo_Click(object sender, EventArgs e)
        {
            panelProdStats.Visible = false;
            panelProdInv.Visible = true;
            panelProdInv.Dock = DockStyle.Fill;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ProductInventory addProd = new ProductInventory();
            addProd.Show();

            //panelProdInv.Visible = false;
            //panelAddProd.Visible = true;
            //panelAddProd.Dock = DockStyle.Fill;

        }

        private void cbACTypeDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProdCategoryDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
