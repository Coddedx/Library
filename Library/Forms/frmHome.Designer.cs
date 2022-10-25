namespace Library
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.flowMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPersonelPage = new System.Windows.Forms.Button();
            this.btnBookPage = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.SideBartimer = new System.Windows.Forms.Timer(this.components);
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlChild = new System.Windows.Forms.Panel();
            this.timerDateClock = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowMenu
            // 
            this.flowMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.flowMenu.Controls.Add(this.panelLogo);
            this.flowMenu.Controls.Add(this.panel1);
            this.flowMenu.Controls.Add(this.btnPersonelPage);
            this.flowMenu.Controls.Add(this.btnBookPage);
            this.flowMenu.Controls.Add(this.btnLogOut);
            this.flowMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowMenu.Location = new System.Drawing.Point(0, 0);
            this.flowMenu.MaximumSize = new System.Drawing.Size(206, 711);
            this.flowMenu.MinimumSize = new System.Drawing.Size(51, 711);
            this.flowMenu.Name = "flowMenu";
            this.flowMenu.Size = new System.Drawing.Size(206, 711);
            this.flowMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.btnMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(200, 77);
            this.panelLogo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(9, 29);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(32, 31);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(3, 86);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(215, 41);
            this.panel1.TabIndex = 10;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-1, -9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(246, 60);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "              Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPersonelPage
            // 
            this.btnPersonelPage.FlatAppearance.BorderSize = 0;
            this.btnPersonelPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnPersonelPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnPersonelPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelPage.Image")));
            this.btnPersonelPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelPage.Location = new System.Drawing.Point(3, 133);
            this.btnPersonelPage.Name = "btnPersonelPage";
            this.btnPersonelPage.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPersonelPage.Size = new System.Drawing.Size(246, 60);
            this.btnPersonelPage.TabIndex = 9;
            this.btnPersonelPage.Text = "              User";
            this.btnPersonelPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelPage.UseVisualStyleBackColor = true;
            this.btnPersonelPage.Click += new System.EventHandler(this.btnPersonelPage_Click_1);
            // 
            // btnBookPage
            // 
            this.btnBookPage.FlatAppearance.BorderSize = 0;
            this.btnBookPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnBookPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookPage.ForeColor = System.Drawing.Color.White;
            this.btnBookPage.Image = ((System.Drawing.Image)(resources.GetObject("btnBookPage.Image")));
            this.btnBookPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookPage.Location = new System.Drawing.Point(3, 199);
            this.btnBookPage.Name = "btnBookPage";
            this.btnBookPage.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBookPage.Size = new System.Drawing.Size(246, 60);
            this.btnBookPage.TabIndex = 9;
            this.btnBookPage.Text = "              Book";
            this.btnBookPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookPage.UseVisualStyleBackColor = true;
            this.btnBookPage.Click += new System.EventHandler(this.btnBookPage_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(3, 265);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(246, 60);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "              Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Location = new System.Drawing.Point(998, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(130, 23);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "           ";
            // 
            // lblClock
            // 
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClock.Location = new System.Drawing.Point(998, 40);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(110, 29);
            this.lblClock.TabIndex = 1;
            this.lblClock.Text = "           ";
            // 
            // SideBartimer
            // 
            this.SideBartimer.Interval = 20;
            this.SideBartimer.Tick += new System.EventHandler(this.SideBartimer_Tick);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.pnlTitle.Controls.Add(this.pictureBox2);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.button1);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.lblDate);
            this.pnlTitle.Controls.Add(this.lblClock);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(206, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1204, 80);
            this.pnlTitle.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1152, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(362, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(94, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // pnlChild
            // 
            this.pnlChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChild.Location = new System.Drawing.Point(206, 80);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(1204, 616);
            this.pnlChild.TabIndex = 3;
            // 
            // timerDateClock
            // 
            this.timerDateClock.Tick += new System.EventHandler(this.timerDateClock_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(968, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(968, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1410, 696);
            this.Controls.Add(this.pnlChild);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.flowMenu);
            this.MaximumSize = new System.Drawing.Size(1428, 743);
            this.Name = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.flowMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPersonelPage;
        private System.Windows.Forms.Button btnBookPage;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SideBartimer;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlChild;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timerDateClock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

