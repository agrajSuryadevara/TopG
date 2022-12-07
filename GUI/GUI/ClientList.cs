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
    public partial class ClientList : Form
    {
        //
        //Fields
        //
        private Button CurrentButton;
        private Panel ButtonPanel;
        public ClientList()
        {
            InitializeComponent();
            ButtonPanel = new Panel();
            ButtonPanel.Size = new Size(5, 60);
            LeftPanel.Controls.Add(ButtonPanel);
            clientList();
        }

        private void ButtonActivated(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                ButtonDisabled();
                //Button
                CurrentButton = (Button)senderBtn;
                CurrentButton.TextAlign = ContentAlignment.MiddleRight;
                //Border
                ButtonPanel.BackColor = color;
                ButtonPanel.Location = new Point(0, CurrentButton.Location.Y);
                ButtonPanel.Visible = true;
                ButtonPanel.BringToFront();
            }
        }

        private void ButtonDisabled()
        {
            if (CurrentButton != null)
            {
                CurrentButton.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
            new Account().Show();
            this.Hide();
        }

        private void ClientListButton_Click(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
        }

        private void IdeasButton_Click(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
            new Ideas().Show();
            this.Hide();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
            new Registration().Show();
            this.Hide();
        }

        private void clientList()
        {
            //Button
            CurrentButton = ClientListButton;
            CurrentButton.TextAlign = ContentAlignment.MiddleRight;
            //Border
            ButtonPanel.BackColor = Color.AliceBlue;
            ButtonPanel.Location = new Point(0, CurrentButton.Location.Y);
            ButtonPanel.Visible = true;
            ButtonPanel.BringToFront();
        }
    }
}

