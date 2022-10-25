using DocumentFormat.OpenXml.Office2010.Excel;
using Library.Model;
using Library.Sql_Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmBook_Load);
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            string conb = "Select * from Book ";
            data_gridBook.DataSource = CRUD.CRUD.List(conb);

            comboBoxFilter.Items.Add("Book Name");  //filtreleme yapmak için kullandığım combo 
            comboBoxFilter.Items.Add("Author Name");
            comboBoxFilter.Items.Add("Page");
            comboBoxFilter.Items.Add("Quote");
        }

        void UpdateBook()
        {
            string con = "Select * from Book ";
            data_gridBook.DataSource = CRUD.CRUD.List(con);
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            frmSaveBook frm = new frmSaveBook();
            frm.ShowDialog();
            if (frm.okey == true) //== true yazmasan da aynı şeye denk gelir bool tanımdladığın için 
            {
                UpdateBook();
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            int _choiceId = Convert.ToInt32(data_gridBook.CurrentRow.Cells["Id"].Value.ToString());
            frmSaveBook frm = new frmSaveBook(_choiceId);

            frm.txtBookName.Text = data_gridBook.CurrentRow.Cells["Book_Name"].Value.ToString();  //değerleri alıyoruz 
            frm.txtAuthor.Text = data_gridBook.CurrentRow.Cells["Author_name"].Value.ToString();
            frm.txtPage.Text = data_gridBook.CurrentRow.Cells["Page"].Value.ToString();  //toint mi olcak??????????????
            frm.txtQuote.Text = data_gridBook.CurrentRow.Cells["Quote"].Value.ToString();

            frm.ShowDialog();
            if (frm.okey == true) //== true yazmasan da aynı şeye denk gelir bool tanımdladığın için 
            {
                UpdateBook();
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                int _choiceId = Convert.ToInt32(data_gridBook.CurrentRow.Cells["Id"].Value.ToString()); 
                string sql = "Delete from Book where Id = '" + _choiceId + "'  ";  
                if (CRUD.CRUD.Crud(sql)==true) 
                {
                    UpdateBook();  
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            UpdateBook();
            MessageBox.Show("Book list updated successfully!");
        }

        private void btnSearchFilter_Click(object sender, EventArgs e)
        {
            Filter();
            //List<string> _filter = new List<string> { "Page", "Quote" };
            //comboBoxFilter.DataSource = _filter;

            //comboBoxFilter.Text = comboBoxFilter.Items[0].ToString();


            // string _f = txtFilter.Text;  //text de yazanı listeye koymaya çalıştım
            //List<int> _f = new List<int>();
            //_f.Add(int.Parse(txtFilter.Text));

            //DataTable dt = new DataTable();  //Datatable ı yeniden ıluşturup kullanıcam ben
            //SQLiteDataAdapter adp = new SQLiteDataAdapter(_sql, Connect.connection);  
            //adp.Fill(dt);

                                       //  DataView dv = a.DefaultView;  //eğer data table ı tekrardan burda oluşturup kullansaydım a yerine dt olurdu

        }

        DataView Filter()
        {
            string _sql = "SELECT * FROM Book ";
            var a = CRUD.CRUD.List(_sql);     //SQLİTE DAKİ VERİLERİ LİSTEYE AKTARMAK İSTİYORUZ (hangi türde gelceğini bilmediğimiz için var)

            List<Book> _bookList = new List<Book>();
            for (int i = 0; i < a.Rows.Count; i++)
            {
                Book _book = new Book();

                _book.Id = Convert.ToInt32(a.Rows[i][a.Columns[0].ColumnName]);
                _book.Book_name = a.Rows[i][a.Columns[1].ColumnName].ToString();
                _book.Author_Name = a.Rows[i][a.Columns[2].ColumnName].ToString();
                _book.Page = a.Rows[i][a.Columns[3].ColumnName].ToString();
                _book.Quote = a.Rows[i][a.Columns[4].ColumnName].ToString();
                _bookList.Add(_book);
            }

            Book bo = new Book();
            bo = _bookList.Find(p => p.Book_name == txtFilter.Text && p.Author_Name == txtFilter.Text && p.Page == txtFilter.Text && p.Quote == txtFilter.Text ); 

            DataView dv = new DataView();
            if (bo!=null)
            {
                if (comboBoxFilter.SelectedIndex == 0)  //page
                {
                    dv.RowFilter = "Book_Name like '" + txtFilter.Text + "%'  ";    //%sona koyduğum için baştan itibaren olanları getircek
                    data_gridBook.DataSource = dv;
                }
                else if (comboBoxFilter.SelectedIndex == 1)  //quote
                {
                    dv.RowFilter = "Author_Name like '" + txtFilter.Text + "%'  ";
                    data_gridBook.DataSource = dv;
                }
                else if (comboBoxFilter.SelectedIndex == 2)  //quote
                {
                    dv.RowFilter = "Page like '" + txtFilter.Text + "%'  ";
                    data_gridBook.DataSource = dv;
                }
                else if (comboBoxFilter.SelectedIndex == 3)  //quote
                {
                    dv.RowFilter = "Quote like '" + txtFilter.Text + "%'  ";
                    data_gridBook.DataSource = dv;
                }
                else
                {
                    MessageBox.Show("Nothing is matching!");
                    UpdateBook();
                }
                
            }
            else
            {
                MessageBox.Show("Test");
            }

            return dv;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
          // Filter();  //burda yaparsam tek bir harf 
        }
    }
}
