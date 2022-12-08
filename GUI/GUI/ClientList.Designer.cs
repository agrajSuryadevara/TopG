namespace GUI
{
    partial class ClientList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientList));
            this.TopPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RegistrationPicture = new System.Windows.Forms.PictureBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.IdeasButton = new System.Windows.Forms.Button();
            this.ClientListButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.dvgClient = new System.Windows.Forms.DataGridView();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.portfolioTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.riskTxt = new System.Windows.Forms.TextBox();
            this.regionTxt = new System.Windows.Forms.TextBox();
            this.countryTxt = new System.Windows.Forms.TextBox();
            this.displayBtt = new System.Windows.Forms.Button();
            this.searchBtt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClient)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.SlateGray;
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.SearchPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1264, 80);
            this.TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SearchPanel
            // 
            this.SearchPanel.AutoScroll = true;
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchBox);
            this.SearchPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchPanel.Location = new System.Drawing.Point(108, 3);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(1144, 79);
            this.SearchPanel.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(346, 35);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(44, 44);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchBox.Location = new System.Drawing.Point(447, 28);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(250, 22);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.Text = "Search";
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.SlateGray;
            this.LeftPanel.Controls.Add(this.pictureBox4);
            this.LeftPanel.Controls.Add(this.pictureBox3);
            this.LeftPanel.Controls.Add(this.pictureBox2);
            this.LeftPanel.Controls.Add(this.RegistrationPicture);
            this.LeftPanel.Controls.Add(this.RegistrationButton);
            this.LeftPanel.Controls.Add(this.IdeasButton);
            this.LeftPanel.Controls.Add(this.ClientListButton);
            this.LeftPanel.Controls.Add(this.AccountButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 80);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(209, 631);
            this.LeftPanel.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(20, 166);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 44);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(20, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 44);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(20, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 44);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // RegistrationPicture
            // 
            this.RegistrationPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegistrationPicture.BackgroundImage")));
            this.RegistrationPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RegistrationPicture.Location = new System.Drawing.Point(20, 240);
            this.RegistrationPicture.Name = "RegistrationPicture";
            this.RegistrationPicture.Size = new System.Drawing.Size(44, 44);
            this.RegistrationPicture.TabIndex = 2;
            this.RegistrationPicture.TabStop = false;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RegistrationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegistrationButton.FlatAppearance.BorderSize = 0;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.RegistrationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistrationButton.Location = new System.Drawing.Point(0, 225);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegistrationButton.Size = new System.Drawing.Size(209, 75);
            this.RegistrationButton.TabIndex = 2;
            this.RegistrationButton.Text = "   Registration";
            this.RegistrationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // IdeasButton
            // 
            this.IdeasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdeasButton.FlatAppearance.BorderSize = 0;
            this.IdeasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdeasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeasButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.IdeasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IdeasButton.Location = new System.Drawing.Point(0, 150);
            this.IdeasButton.Name = "IdeasButton";
            this.IdeasButton.Size = new System.Drawing.Size(209, 75);
            this.IdeasButton.TabIndex = 2;
            this.IdeasButton.Text = "Ideas";
            this.IdeasButton.UseVisualStyleBackColor = true;
            this.IdeasButton.Click += new System.EventHandler(this.IdeasButton_Click);
            // 
            // ClientListButton
            // 
            this.ClientListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientListButton.FlatAppearance.BorderSize = 0;
            this.ClientListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientListButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ClientListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientListButton.Location = new System.Drawing.Point(0, 75);
            this.ClientListButton.Name = "ClientListButton";
            this.ClientListButton.Size = new System.Drawing.Size(209, 75);
            this.ClientListButton.TabIndex = 2;
            this.ClientListButton.Text = "Client List";
            this.ClientListButton.UseVisualStyleBackColor = true;
            this.ClientListButton.Click += new System.EventHandler(this.ClientListButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountButton.FlatAppearance.BorderSize = 0;
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.AccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountButton.Location = new System.Drawing.Point(0, 0);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(209, 75);
            this.AccountButton.TabIndex = 2;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // dvgClient
            // 
            this.dvgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClient.Location = new System.Drawing.Point(216, 89);
            this.dvgClient.Name = "dvgClient";
            this.dvgClient.RowHeadersWidth = 51;
            this.dvgClient.RowTemplate.Height = 24;
            this.dvgClient.Size = new System.Drawing.Size(589, 610);
            this.dvgClient.TabIndex = 2;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(852, 116);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(385, 22);
            this.nameTxt.TabIndex = 3;
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(852, 170);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(385, 22);
            this.surnameTxt.TabIndex = 4;
            // 
            // portfolioTxt
            // 
            this.portfolioTxt.Location = new System.Drawing.Point(852, 230);
            this.portfolioTxt.Name = "portfolioTxt";
            this.portfolioTxt.Size = new System.Drawing.Size(385, 22);
            this.portfolioTxt.TabIndex = 5;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(852, 283);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(385, 22);
            this.emailTxt.TabIndex = 6;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(852, 342);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(385, 22);
            this.phoneTxt.TabIndex = 7;
            // 
            // riskTxt
            // 
            this.riskTxt.Location = new System.Drawing.Point(852, 395);
            this.riskTxt.Name = "riskTxt";
            this.riskTxt.Size = new System.Drawing.Size(385, 22);
            this.riskTxt.TabIndex = 8;
            // 
            // regionTxt
            // 
            this.regionTxt.Location = new System.Drawing.Point(852, 456);
            this.regionTxt.Name = "regionTxt";
            this.regionTxt.Size = new System.Drawing.Size(385, 22);
            this.regionTxt.TabIndex = 9;
            // 
            // countryTxt
            // 
            this.countryTxt.Location = new System.Drawing.Point(852, 511);
            this.countryTxt.Name = "countryTxt";
            this.countryTxt.Size = new System.Drawing.Size(385, 22);
            this.countryTxt.TabIndex = 10;
            // 
            // displayBtt
            // 
            this.displayBtt.Location = new System.Drawing.Point(852, 622);
            this.displayBtt.Name = "displayBtt";
            this.displayBtt.Size = new System.Drawing.Size(112, 64);
            this.displayBtt.TabIndex = 11;
            this.displayBtt.Text = "Display";
            this.displayBtt.UseVisualStyleBackColor = true;
            this.displayBtt.Click += new System.EventHandler(this.displayBtt_Click_1);
            // 
            // searchBtt
            // 
            this.searchBtt.Location = new System.Drawing.Point(1087, 622);
            this.searchBtt.Name = "searchBtt";
            this.searchBtt.Size = new System.Drawing.Size(112, 64);
            this.searchBtt.TabIndex = 12;
            this.searchBtt.Text = "Search";
            this.searchBtt.UseVisualStyleBackColor = true;
            this.searchBtt.Click += new System.EventHandler(this.searchBtt_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(852, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(852, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(852, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Portfolio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(852, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(849, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(849, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Risk Preference";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(849, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Region";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(849, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Country";
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtt);
            this.Controls.Add(this.displayBtt);
            this.Controls.Add(this.countryTxt);
            this.Controls.Add(this.regionTxt);
            this.Controls.Add(this.riskTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.portfolioTxt);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.dvgClient);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "ClientList";
            this.Text = "Top G";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TopPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button IdeasButton;
        private System.Windows.Forms.Button ClientListButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox RegistrationPicture;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dvgClient;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.TextBox portfolioTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox riskTxt;
        private System.Windows.Forms.TextBox regionTxt;
        private System.Windows.Forms.TextBox countryTxt;
        private System.Windows.Forms.Button displayBtt;
        private System.Windows.Forms.Button searchBtt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}