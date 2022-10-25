using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library.Forms
{
    public partial class frmSaveBook : Form
    {
        int? Id = null;
        public bool okey = false;
        public frmSaveBook(int? Id=null)
        {
            InitializeComponent();
            if (Id != null) //ıd doluysa edit boşsa ekleme olcak
            {
                this.Id = Id;
            }
        }

        private void frmSaveBoo_Load(object sender, EventArgs e)
        {

        }

        private void btnBookSave_Click(object sender, EventArgs e)
        {
            if (Id == null)
            {
                string sql = "Insert into Book(Book_name, Author_Name, Page, Quote) Values (' " + txtBookName.Text + " ' , '" + txtAuthor.Text + "' , '" + txtPage.Text + "' , '" + txtQuote.Text + "'  ) ";

                if (CRUD.CRUD.Crud(sql) == true)
                {
                    okey = true;
                    MessageBox.Show("New book added successfully!");
                    this.Close();
                }
            }
            else
            {
                string sql = "Update Book set Book_name='" + txtBookName.Text + "' ,Author_Name= '" + txtAuthor.Text + "' , Page='" + txtPage.Text + "' ,Quote= '" + txtQuote.Text + "' Where Id= '" + Id + "'   ";
                if (CRUD.CRUD.Crud(sql) == true)
                {
                    okey = true;
                    MessageBox.Show("Updated successfully!");
                    this.Close();
                }

            }
        }
    }
}
