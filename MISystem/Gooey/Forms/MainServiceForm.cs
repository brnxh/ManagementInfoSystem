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
            panelSchedList.Visible = true;
            panelSchedList.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelSchedList.Visible = false;
        }
    }
}
