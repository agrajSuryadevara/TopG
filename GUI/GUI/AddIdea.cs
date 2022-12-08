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
    public partial class AddIdea : Form
    {
        //
        //Fields
        //
        private Button CurrentButton;
        private Panel ButtonPanel;
        public AddIdea()
        {
            InitializeComponent();
            ButtonPanel = new Panel();
            ButtonPanel.Size = new Size(5, 60);
            LeftPanel.Controls.Add(ButtonPanel);
            addIDea();
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
            new AccountAI().Show();
            this.Hide();
        }

        private void AddIdeaButton_Click(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
        }

        private void IdeasButton_Click(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
            new IdeaAI().Show();
            this.Hide();
        }
        private void addIDea()
        {
            //Button
            CurrentButton = AddIdeaButton;
            CurrentButton.TextAlign = ContentAlignment.MiddleRight;
            //Border
            ButtonPanel.BackColor = Color.AliceBlue;
            ButtonPanel.Location = new Point(0, CurrentButton.Location.Y);
            ButtonPanel.Visible = true;
            ButtonPanel.BringToFront();
        }

        private void AddIdea_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();


            int Idea_ID = Convert.ToInt32(textBoxID.Text);
            string Title = textBoxTitle.Text;
            string Abstract = textBoxAbstract.Text;
            int Publish_date = Convert.ToInt32(textBoxPublishDate.Text);
            int Expiry_date = Convert.ToInt32(textBoxExpiryDate.Text);
            string Author = textBoxAuthor.Text;
            string Content = textBoxContent.Text;
            int Risk_rating = Convert.ToInt32(textBoxRiskRating.Text);
            string Product_type = textBoxProductType.Text;
            string Instrument = textBoxInstrument.Text;
            string Currency = textBoxCurrency.Text;
            string Major_sector = textBoxMajorSector.Text;
            string Minor_sector = textBoxMinorSector.Text;
            string Region = textBoxRegion.Text;
            string Country = textBoxCountry.Text;


            dbConn.addIdeaToDB("INSERT INTO Ideas (Idea_ID, Title, Abstract, Publish_date, Expiry_date, Author, Content, Risk_rating, Product_type, Instrument, Currency, Major_sector, Minor_sector, Region, Country)" +
                " VALUES (@Idea_ID, @Title, @Abstract, @Publish_date, @Expiry_date, @Author, @Content, @Risk_rating, @Product_type, @Instrument, @Currency, @Major_sector, @Minor_sector, @Region, @Country)",
                Idea_ID, Title, Abstract, Publish_date, Expiry_date, Author, Content, Risk_rating, Product_type, Instrument, Currency, Major_sector, Minor_sector, Region, Country);


            MessageBox.Show("Successfully uploaded.");

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}