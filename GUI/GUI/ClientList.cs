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

        private void displayBtt_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Client";
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet dsClient = dbConn.getDataSet(query);
            dvgClient.DataSource = dsClient.Tables[0];
        }

        private void searchBtt_Click_1(object sender, EventArgs e)
        {
            string name, surname, portfolio, phone, email, risk, region, country, query;

            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();

            name = nameTxt.Text;
            surname = surnameTxt.Text;
            portfolio = portfolioTxt.Text;
            phone = phoneTxt.Text;
            email = emailTxt.Text;
            risk = riskTxt.Text;
            region = regionTxt.Text;
            country = countryTxt.Text;
            query = "SELECT * FROM Client WHERE Name='" + name + "' OR Surname='" + surname + "' OR Portfolio='" + portfolio + "' OR PhoneNumber='" + phone + "' OR Email='" + email + "' " +
                "OR RiskPreference='" + risk + "' OR Region='" + region + "' OR Country='" + country + "'";

            DataTable dtClient = dbConn.searchData(query);
            dvgClient.DataSource = dtClient;
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

