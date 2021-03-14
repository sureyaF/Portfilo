using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _101062225_eventManagement_project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

       

        private void btnLogin_Click(object sender, EventArgs e){
             
            String Username = "admin";

            String Password = "admin";


            if(txtUser.Text == Username && txtPassword.Text == Password)
            {
                if (ValidateChildren(ValidationConstraints.Enabled)){
                MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                Main_Form f2 = new Main_Form();
                f2.ShowDialog(); 
                }

            }
            else
            {

                MessageBox.Show("Please Check your Username and Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void TxtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                e.Cancel = true;
                txtUser.Focus();
                errorProviderApp.SetError(txtUser, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtUser, "");
            }
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProviderApp.SetError(txtPassword, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtPassword, "");
            }
        }
    }
}
