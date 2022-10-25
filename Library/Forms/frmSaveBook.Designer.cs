namespace Library.Forms
{
    partial class frmSaveBook
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
            this.btnBookSave = new System.Windows.Forms.Button();
            this.txtQuote = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBookSave
            // 
            this.btnBookSave.Location = new System.Drawing.Point(182, 186);
            this.btnBookSave.Name = "btnBookSave";
            this.btnBookSave.Size = new System.Drawing.Size(87, 34);
            this.btnBookSave.TabIndex = 24;
            this.btnBookSave.Text = "Save";
            this.btnBookSave.UseVisualStyleBackColor = true;
            this.btnBookSave.Click += new System.EventHandler(this.btnBookSave_Click);
            // 
            // txtQuote
            // 
            this.txtQuote.Location = new System.Drawing.Point(153, 146);
            this.txtQuote.Name = "txtQuote";
            this.txtQuote.Size = new System.Drawing.Size(163, 22);
            this.txtQuote.TabIndex = 20;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(153, 118);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(163, 22);
            this.txtPage.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quote :";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(153, 90);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(163, 22);
            this.txtAuthor.TabIndex = 22;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(153, 62);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(163, 22);
            this.txtBookName.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Quote\'s Page : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Author\'s Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Book\'s Name : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 45);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book And Author ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSaveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 249);
            this.Controls.Add(this.btnBookSave);
            this.Controls.Add(this.txtQuote);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSaveBook";
            this.Load += new System.EventHandler(this.frmSaveBoo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookSave;
        public System.Windows.Forms.TextBox txtQuote;
        public System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtAuthor;
        public System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}