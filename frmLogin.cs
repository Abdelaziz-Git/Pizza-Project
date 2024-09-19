using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if((txtUsername.Text==txtUsername.Tag.ToString())
                &&(txtPassword.Text==txtPassword.Tag.ToString()))
            {
                Form frm = new frmPizzaOrder();
                frm.Show();
            }
            else
            {
                if(MessageBox.Show("Invalid Username Or Password", "Login error",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)==DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                }
                
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pbShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void pbHidePassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

        }
    }
}
