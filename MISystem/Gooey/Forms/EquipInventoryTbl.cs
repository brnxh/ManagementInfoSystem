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
    public partial class EquipInventoryTbl : Form
    {
        public EquipInventoryTbl()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            EquipStats showStats = new EquipStats();
            showStats.Show();
            //frmMain.frmMainInstance.Show();
            //EquipmentInventory addEquip = new EquipmentInventory();
            //addEquip.TopLevel = false;
            //panelChildForm.Controls.Add(addEquip);


            
        }

        private void EquipInventoryTbl_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            EquipmentInventory addEquip = new EquipmentInventory();
            addEquip.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            EquipmentInventory addEquip = new EquipmentInventory();
            addEquip.Show();
        }
    }
}
