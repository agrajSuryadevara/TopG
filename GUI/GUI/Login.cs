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
            if (UsernameTextBox.Text == "RM" && PasswordTextBox.Text == "demo")
            {
                new RM().Show();
                this.Hide();
            }

            if (UsernameTextBox.Text == "AI" && PasswordTextBox.Text == "demo")
            {
                new IdeaAI().Show();
                this.Hide();
            }


            else
            {
                MessageBox.Show("Your credentials combination are wrong!");
                UsernameTextBox.Clear();
                PasswordTextBox.Clear();
            }
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
