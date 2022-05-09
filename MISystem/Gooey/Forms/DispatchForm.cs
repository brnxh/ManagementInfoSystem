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
    public partial class DispatchForm : Form
    {
        public DispatchForm()
        {
            InitializeComponent();
        }

        private void DispatchForm_Load(object sender, EventArgs e)
        {
            // TRIGGER CONFIRM FIRST APPROACH
            //panelValidate.Visible = true;
            //panelValidate.Dock = DockStyle.Fill;
            //panelDispatchForm.Visible = false;
            //panelDispatchList.Visible = false;

            panelDispatchList.Visible = true;
            panelDispatchList.Dock = DockStyle.Fill;
            panelValidate.Visible = false;
            panelDispatchForm.Visible = false;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelDispatchList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddDispatch_Click(object sender, EventArgs e)
        {
            panelDispatchList.Visible = false;

            panelDispatchForm.Visible = true;
            panelDispatchForm.Dock = DockStyle.Fill;
        }

        private void btnSaveDisp_Click(object sender, EventArgs e)
        {
            panelDispatchForm.Visible = false;

            panelDispatchList.Visible = true;
            panelDispatchList.Dock = DockStyle.Fill;
        }
    }
}
