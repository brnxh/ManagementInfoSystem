﻿using System;
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

        private void EquipInventoryTbl_Load(object sender, EventArgs e)
        {
            panelEquipStats.Visible = true;
            panelEquipStats.Dock = DockStyle.Fill;

            panelValidate.Visible = false;
            

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

        private void panelEquipStats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //panelValidate.Visible = true;
            //panelValidate.Dock = DockStyle.Fill;


            panelEquipStats.Visible = false;


            //panelEquipStats.Visible = false;
        }
    }
}
