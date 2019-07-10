using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Work
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ChShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar=false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void BtnSigin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
         
            string userpassword = txtPassword.Text.Trim();


            if (username=="Admin" && userpassword=="admin12345")
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Youre password or username wrong");
            }
        }
    }
}
