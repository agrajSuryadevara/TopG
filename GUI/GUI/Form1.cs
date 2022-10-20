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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
