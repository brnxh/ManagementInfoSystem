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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelCustomerSubMenu.Visible = false;
            panelEmpSubMenu.Visible = false;
            panelVentorySubMenu.Visible = false;
            panelSrvsSubMenu.Visible = false;
            panelSettingSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCustomerSubMenu);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpSubMenu);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVentorySubMenu);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSrvsSubMenu);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSettingSubMenu);
        }
    }
}
