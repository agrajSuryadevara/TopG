namespace GUI
{
    partial class RM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RM));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.s = new System.Windows.Forms.FlowLayoutPanel();
            this.AccountButton = new System.Windows.Forms.Button();
            this.ClientListButton = new System.Windows.Forms.Button();
            this.IdeasButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.RegistrationPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.Transparent;
            this.s.Controls.Add(this.pictureBox1);
            this.s.Dock = System.Windows.Forms.DockStyle.Top;
            this.s.Location = new System.Drawing.Point(0, 0);
            this.s.Margin = new System.Windows.Forms.Padding(2);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(948, 92);
            this.s.TabIndex = 0;
            this.s.Paint += new System.Windows.Forms.PaintEventHandler(this.s_Paint);
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
            this.AccountButton.Margin = new System.Windows.Forms.Padding(2);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(140, 61);
            this.AccountButton.TabIndex = 2;
            this.AccountButton.Text = "Account";
            this.AccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // ClientListButton
            // 
            this.ClientListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientListButton.FlatAppearance.BorderSize = 0;
            this.ClientListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientListButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ClientListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientListButton.Location = new System.Drawing.Point(0, 61);
            this.ClientListButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClientListButton.Name = "ClientListButton";
            this.ClientListButton.Size = new System.Drawing.Size(140, 61);
            this.ClientListButton.TabIndex = 2;
            this.ClientListButton.Text = "Client List";
            this.ClientListButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClientListButton.UseVisualStyleBackColor = true;
            this.ClientListButton.Click += new System.EventHandler(this.ClientListButton_Click);
            // 
            // IdeasButton
            // 
            this.IdeasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdeasButton.FlatAppearance.BorderSize = 0;
            this.IdeasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdeasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeasButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.IdeasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IdeasButton.Location = new System.Drawing.Point(0, 122);
            this.IdeasButton.Margin = new System.Windows.Forms.Padding(2);
            this.IdeasButton.Name = "IdeasButton";
            this.IdeasButton.Size = new System.Drawing.Size(140, 61);
            this.IdeasButton.TabIndex = 2;
            this.IdeasButton.Text = "Ideas";
            this.IdeasButton.UseVisualStyleBackColor = true;
            this.IdeasButton.Click += new System.EventHandler(this.IdeasButton_Click);
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
            this.RegistrationButton.Location = new System.Drawing.Point(0, 183);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegistrationButton.Size = new System.Drawing.Size(140, 61);
            this.RegistrationButton.TabIndex = 2;
            this.RegistrationButton.Text = "   Registration";
            this.RegistrationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // RegistrationPicture
            // 
            this.RegistrationPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegistrationPicture.BackgroundImage")));
            this.RegistrationPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RegistrationPicture.Location = new System.Drawing.Point(15, 195);
            this.RegistrationPicture.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationPicture.Name = "RegistrationPicture";
            this.RegistrationPicture.Size = new System.Drawing.Size(33, 36);
            this.RegistrationPicture.TabIndex = 2;
            this.RegistrationPicture.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(15, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 36);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(15, 73);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 36);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(15, 135);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 36);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.LeftPanel.Controls.Add(this.pictureBox4);
            this.LeftPanel.Controls.Add(this.pictureBox3);
            this.LeftPanel.Controls.Add(this.pictureBox2);
            this.LeftPanel.Controls.Add(this.RegistrationPicture);
            this.LeftPanel.Controls.Add(this.RegistrationButton);
            this.LeftPanel.Controls.Add(this.IdeasButton);
            this.LeftPanel.Controls.Add(this.ClientListButton);
            this.LeftPanel.Controls.Add(this.AccountButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 92);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(140, 486);
            this.LeftPanel.TabIndex = 1;
            // 
            // RM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 578);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.s);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RM";
            this.Text = "Top G";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.s.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel s;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button ClientListButton;
        private System.Windows.Forms.Button IdeasButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.PictureBox RegistrationPicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel LeftPanel;
    }
}