using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UserEmailTextBox.ForeColor = Color.Black;
            }
            catch { }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PasswordTextBox.ForeColor = Color.Black;
            }
            catch { }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            String email, password, role;

            email = UserEmailTextBox.Text;
            password = PasswordTextBox.Text;

            role = dbConn.validateLogin(email, password);

            if (role == "RM")
            {
                RM rm = new RM();
                rm.Show();
                this.Hide();
            }
            else if(role == "AI")
            {
                AuthorIdea ai = new AuthorIdea();
                ai.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your credentials don't match. \n Email or Password are wrong");
            }
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}
