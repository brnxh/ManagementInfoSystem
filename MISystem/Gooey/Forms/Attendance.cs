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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }



        private void Attendance_Load(object sender, EventArgs e)
        {
            panelValidate.Visible = true;
            panelValidate.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
