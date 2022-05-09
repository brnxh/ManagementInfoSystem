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
    public partial class AuditLog : Form
    {
        public AuditLog()
        {
            InitializeComponent();
        }

        private void AuditLog_Load(object sender, EventArgs e)
        {
            //panelValidate.Visible = true;
            //panelValidate.Dock = DockStyle.Fill;

            panelValidate.Visible = false;
        }
    }
}
