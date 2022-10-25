
using Library.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Login_Load);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

      //  SqlConnection conn = new SqlConnection("Data Source=.\\Library2DB.db;");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _mailLogin, _passwordLogin;
            _mailLogin = txtMail.Text;
            _passwordLogin = txtMail.Text;

            string _sql = "SELECT * FROM information ";

            var a = CRUD.CRUD.List(_sql);     //SQLİTE DAKİ VERİLERİ LİSTEYE AKTARMAK İSTİYORUZ
            List<User> _userList = new List<User>();
            for (int i = 0; i < a.Rows.Count; i++)
            {
                User _user = new User();

                _user.Id = Convert.ToInt32(a.Rows[i][a.Columns[0].ColumnName]);
                _user.First_And_Second_Name = a.Rows[i][a.Columns[1].ColumnName].ToString();
                _user.Telephone_No = a.Rows[i][a.Columns[2].ColumnName].ToString();
                _user.Mail = a.Rows[i][a.Columns[3].ColumnName].ToString();
                _user.Password = a.Rows[i][a.Columns[4].ColumnName].ToString();
                // a.Rows[i][a.Columns[j].ColumnName].ToString();
                _userList.Add(_user);
            }

            User us = new User();
            us = _userList.Find(p => p.Mail == _mailLogin && p.Password == _passwordLogin);  //girilen verileri sqlite daki verileri çektiğimiz listede varsa us diye oluşturduğumuz yeni bir nesne içine yazılıyor 
            if (us != null)  //eğer us nesnesi doluysa girilen ve sqlite daki veri aynı ki find ile atmışız içine 
            {
                Thread.Sleep(1000);
                this.Hide();
                frmHome frm = new frmHome();
                frm.Closed += (s, args) => this.Close();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Something is wrong !! Try Again");
                txtMail.Clear();
                txtPassword.Clear();

                txtMail.Focus(); //neden????????????????
            }
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
