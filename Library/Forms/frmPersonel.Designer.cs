namespace Library.Forms
{
    partial class frmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonel));
            this.groupBoxPersonel = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.data_gridPersonel = new System.Windows.Forms.DataGridView();
            this.groupBoxPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gridPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPersonel
            // 
            this.groupBoxPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.groupBoxPersonel.Controls.Add(this.btnUpdate);
            this.groupBoxPersonel.Controls.Add(this.btnDelete);
            this.groupBoxPersonel.Controls.Add(this.btnEdit);
            this.groupBoxPersonel.Controls.Add(this.btnNew);
            this.groupBoxPersonel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxPersonel.Location = new System.Drawing.Point(0, 591);
            this.groupBoxPersonel.Name = "groupBoxPersonel";
            this.groupBoxPersonel.Size = new System.Drawing.Size(1227, 52);
            this.groupBoxPersonel.TabIndex = 3;
            this.groupBoxPersonel.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(647, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 28);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "       Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(523, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "        Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(410, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 29);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "     Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(298, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 28);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "    New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // data_gridPersonel
            // 
            this.data_gridPersonel.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.data_gridPersonel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_gridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gridPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_gridPersonel.Location = new System.Drawing.Point(0, 0);
            this.data_gridPersonel.Name = "data_gridPersonel";
            this.data_gridPersonel.RowHeadersWidth = 51;
            this.data_gridPersonel.RowTemplate.Height = 24;
            this.data_gridPersonel.Size = new System.Drawing.Size(1227, 591);
            this.data_gridPersonel.TabIndex = 4;
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 643);
            this.Controls.Add(this.data_gridPersonel);
            this.Controls.Add(this.groupBoxPersonel);
            this.Name = "frmPersonel";
            this.Text = "Users List";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            this.groupBoxPersonel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_gridPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView data_gridPersonel;
    }
}