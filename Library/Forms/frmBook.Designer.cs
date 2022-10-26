namespace Library.Forms
{
    partial class frmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook));
            this.groupBoxBook = new System.Windows.Forms.GroupBox();
            this.btnNewBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.data_gridBook = new System.Windows.Forms.DataGridView();
            this.pnlFilterBook = new System.Windows.Forms.Panel();
            this.btnSearchFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.groupBoxBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gridBook)).BeginInit();
            this.pnlFilterBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBook
            // 
            this.groupBoxBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.groupBoxBook.Controls.Add(this.btnNewBook);
            this.groupBoxBook.Controls.Add(this.btnEditBook);
            this.groupBoxBook.Controls.Add(this.btnDeleteBook);
            this.groupBoxBook.Controls.Add(this.btnUpdateBook);
            this.groupBoxBook.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxBook.Location = new System.Drawing.Point(997, 0);
            this.groupBoxBook.Name = "groupBoxBook";
            this.groupBoxBook.Size = new System.Drawing.Size(112, 660);
            this.groupBoxBook.TabIndex = 6;
            this.groupBoxBook.TabStop = false;
            // 
            // btnNewBook
            // 
            this.btnNewBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewBook.FlatAppearance.BorderSize = 0;
            this.btnNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBook.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewBook.ForeColor = System.Drawing.Color.White;
            this.btnNewBook.Image = ((System.Drawing.Image)(resources.GetObject("btnNewBook.Image")));
            this.btnNewBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewBook.Location = new System.Drawing.Point(12, 13);
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(94, 31);
            this.btnNewBook.TabIndex = 4;
            this.btnNewBook.Text = "        New";
            this.btnNewBook.UseVisualStyleBackColor = true;
            this.btnNewBook.Click += new System.EventHandler(this.btnNewBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditBook.FlatAppearance.BorderSize = 0;
            this.btnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBook.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditBook.ForeColor = System.Drawing.Color.White;
            this.btnEditBook.Image = ((System.Drawing.Image)(resources.GetObject("btnEditBook.Image")));
            this.btnEditBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditBook.Location = new System.Drawing.Point(15, 59);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(85, 32);
            this.btnEditBook.TabIndex = 3;
            this.btnEditBook.Text = "        Edit";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBook.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBook.Image")));
            this.btnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBook.Location = new System.Drawing.Point(16, 106);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(96, 33);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "        Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateBook.FlatAppearance.BorderSize = 0;
            this.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBook.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBook.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBook.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateBook.Image")));
            this.btnUpdateBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateBook.Location = new System.Drawing.Point(5, 156);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(107, 34);
            this.btnUpdateBook.TabIndex = 1;
            this.btnUpdateBook.Text = "        Update";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // data_gridBook
            // 
            this.data_gridBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_gridBook.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.data_gridBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_gridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gridBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_gridBook.Location = new System.Drawing.Point(0, 0);
            this.data_gridBook.Name = "data_gridBook";
            this.data_gridBook.RowHeadersWidth = 51;
            this.data_gridBook.RowTemplate.Height = 24;
            this.data_gridBook.Size = new System.Drawing.Size(997, 660);
            this.data_gridBook.TabIndex = 8;
            // 
            // pnlFilterBook
            // 
            this.pnlFilterBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.pnlFilterBook.Controls.Add(this.btnClearFilter);
            this.pnlFilterBook.Controls.Add(this.btnSearchFilter);
            this.pnlFilterBook.Controls.Add(this.txtFilter);
            this.pnlFilterBook.Controls.Add(this.comboBoxFilter);
            this.pnlFilterBook.Controls.Add(this.lblFilter);
            this.pnlFilterBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFilterBook.Location = new System.Drawing.Point(0, 612);
            this.pnlFilterBook.Name = "pnlFilterBook";
            this.pnlFilterBook.Size = new System.Drawing.Size(997, 48);
            this.pnlFilterBook.TabIndex = 9;
            // 
            // btnSearchFilter
            // 
            this.btnSearchFilter.FlatAppearance.BorderSize = 0;
            this.btnSearchFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchFilter.ForeColor = System.Drawing.Color.White;
            this.btnSearchFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFilter.Image")));
            this.btnSearchFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFilter.Location = new System.Drawing.Point(416, 4);
            this.btnSearchFilter.Name = "btnSearchFilter";
            this.btnSearchFilter.Size = new System.Drawing.Size(116, 35);
            this.btnSearchFilter.TabIndex = 3;
            this.btnSearchFilter.Text = "   Search";
            this.btnSearchFilter.UseVisualStyleBackColor = true;
            this.btnSearchFilter.Click += new System.EventHandler(this.btnSearchFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(212, 11);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(177, 22);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(54, 11);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFilter.TabIndex = 1;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(12, 14);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(36, 16);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.Image")));
            this.btnClearFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearFilter.Location = new System.Drawing.Point(538, 4);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(106, 35);
            this.btnClearFilter.TabIndex = 4;
            this.btnClearFilter.Text = "Clear";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 660);
            this.Controls.Add(this.pnlFilterBook);
            this.Controls.Add(this.data_gridBook);
            this.Controls.Add(this.groupBoxBook);
            this.Name = "frmBook";
            this.Text = "Book and Author";
            this.groupBoxBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_gridBook)).EndInit();
            this.pnlFilterBook.ResumeLayout(false);
            this.pnlFilterBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.DataGridView data_gridBook;
        private System.Windows.Forms.Panel pnlFilterBook;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnSearchFilter;
        private System.Windows.Forms.Button btnClearFilter;
    }
}