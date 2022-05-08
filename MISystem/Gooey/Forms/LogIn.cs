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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text == "admin" && tbPassWord.Text == "password")
            {
                new frmMain().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your credentials, ", "Log-In");
            }

        }




        //private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        //{
        //    if(checkShowPass.Checked == true)
        //    {
        //        tbPass.UseSystemPasswordChar = false;
        //    }
        //    else
        //    {
        //        tbPass.UseSystemPasswordChar = true;
        //    }
        //}
    }
    }
