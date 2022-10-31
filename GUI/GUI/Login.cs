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
                UsernameTextBox.ForeColor = Color.Black;
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
            if (UsernameTextBox.Text == "topg" && PasswordTextBox.Text == "demo")
            {
                new RM().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your credentials combination are wrong!");
                UsernameTextBox.Clear();
                PasswordTextBox.Clear();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ForgotPasswordButton_Click(object sender, EventArgs e)
        {

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hello_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
