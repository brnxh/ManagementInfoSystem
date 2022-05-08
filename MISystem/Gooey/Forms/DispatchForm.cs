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
            panelValidate.Visible = true;
            panelValidate.Dock = DockStyle.Fill;

            //panelDispatchList.Visible = true;
            //panelDispatchList.Dock = DockStyle.Fill;
        }
    }
}
