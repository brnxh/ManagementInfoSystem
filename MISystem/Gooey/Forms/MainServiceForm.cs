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
    public partial class MainServiceForm : Form
    {
        public MainServiceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainServiceForm_Load(object sender, EventArgs e)
        {

            //panelValidate.Visible = true;
            //panelValidate.Dock = DockStyle.Fill;

            panelValidate.Visible = false;
            panelSchedForm.Visible = false;
            panelSchedList.Visible = true;
            panelSchedList.Dock = DockStyle.Fill;

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDispatchList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveSched_Click(object sender, EventArgs e)
        {
            panelSchedForm.Visible = false;

            panelSchedList.Visible = true;
            panelSchedList.Dock = DockStyle.Fill;
        }

        private void btnAddSched_Click(object sender, EventArgs e)
        {
            panelSchedList.Visible = false;

            panelSchedForm.Visible = true;
            panelSchedForm.Dock = DockStyle.Fill;
        }
    }
}
