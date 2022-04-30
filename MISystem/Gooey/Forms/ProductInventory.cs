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
    public partial class ProductInventory : Form
    {
        public ProductInventory()
        {
            InitializeComponent();
        }

        private void ProductInventory_Load(object sender, EventArgs e)
        {

        }

        private void cbProdCategoryDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProdCategoryDrop.SelectedItem == "Aircon")
            {
                lblACType.Visible = true;
                cbACTypeDrop.Visible = true;
                lblHP.Visible = true;
                cbHPDrop.Visible = true;
            }
            else
            {
                lblACType.Visible = false;
                cbACTypeDrop.Visible = false;
                lblHP.Visible = false;
                cbHPDrop.Visible = false;
            }
        }
    }
}
