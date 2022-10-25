using Library.CRUD;
using Library.Sql_Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
           this.Load += new System.EventHandler(this.frmPersonel_Load);
        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            string con = "Select Id,First_And_Last_Name,Telephone_No,Mail,Password from information ";  //(information) sqlite.db deki tablo ismi  
            //tek tek seçmek istiyorsak -> "Select id,first and second name... from information"
            //eğer virgüllü bir veri varsa onu almak için cast işlemi gerçekleştirilmeli-> ... ,Cast(Maas as varchar) as Maas, ... from ...

            data_gridPersonel.DataSource = CRUD.CRUD.List(con);
        }
        void UpdatePersonel() //Sqlite daki verileri alıp yansıtıcak (yani ekleme-silme-değiştirme falan yapıldıysa yeni tabloyu gösterebilmek için)
        {
            string con = "Select * from information ";

            data_gridPersonel.DataSource = CRUD.CRUD.List(con);
        }

        private void btnNew_Click(object sender, EventArgs e) //Formda new e basıldıysa diğer formu çağırıp verileri girmesini sağlıcaz
        {
            string con = "Select Id,First_And_Last_Name,Telephone_No,Mail,Password from information ";  //(information) sqlite.db deki tablo ismi  
            //tek tek seçmek istiyorsak -> "Select id,first and second name... from information"
            //eğer virgüllü bir veri varsa onu almak için cast işlemi gerçekleştirilmeli-> ... ,Cast(Maas as varchar) as Maas, ... from ...

            data_gridPersonel.DataSource = CRUD.CRUD.List(con);
            frmSavePersonel frm = new frmSavePersonel(); //Yeni personel kaydedince o formu çağırcak direk (burda class ı çağırıyoruz)
            frm.ShowDialog();  //burda formu çağırıyoruz (her hangi bir parametre eklemiyoruz7

            if (frm.okey == true) //== true yazmasan da aynı şeye denk gelir bool tanımdladığın için 
            {
                UpdatePersonel();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            //Edit butonuna tıkladığımızda personel formundan seçili personelin kaydını göndermemiz gerekiyor artık 
            int _choiceId = Convert.ToInt32(data_gridPersonel.CurrentRow.Cells["Id"].Value.ToString()); //seçili id nin verilerini alıyoruz (sqlite tablosundaki isimini yazıyoruz(Id))
            //data grid de seçili olan string değeri int e çevirerek parametreye atıyoruz bunu da personel editleme formuna yollucaz

            frmSavePersonel frm = new frmSavePersonel(_choiceId);   //diğer formu çağırabilmek için nesne oluşturuyoruz (içine de hangi id yi seçtiğimizi belirten _choiceId yi yolluyoruz)

            frm.txtName.Text = data_gridPersonel.CurrentRow.Cells["First_And_Last_Name"].Value.ToString();  //değerleri alıyoruz 
            frm.txtTelephone.Text = data_gridPersonel.CurrentRow.Cells["Telephone_No"].Value.ToString(); //sqlite tablosundaki isimler
            frm.txtMail.Text = data_gridPersonel.CurrentRow.Cells["Mail"].Value.ToString();
            frm.txtPassword.Text = data_gridPersonel.CurrentRow.Cells["Password"].Value.ToString();

            frm.ShowDialog();
            //edit dediğimizde burdan düzenleyebilmek için frmSave daki tlefon,mail.. textlerinin modifiers özelliğini public yaptık

            if (frm.okey == true) //== true yazmasan da aynı şeye denk gelir bool tanımdladığın için 
            {
                UpdatePersonel();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)  //Formda deleteye basıldıysa seçili ıd yi crud a yolluyor ki silsin
        {


            if (MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //silmeden önce emin misin diye soru sorucaz 
            {
                int _choiceId = Convert.ToInt32(data_gridPersonel.CurrentRow.Cells["Id"].Value.ToString()); //seçili id nin verilerini alıyoruz
                string sql = "Delete from information where Id = '" + _choiceId + "'  ";  //silinmesi istenen id yi alıp crud da içine göndercez
                if (CRUD.CRUD.Crud(sql)) //==true demekle aynı şey çünkü crud methodundan true döndürürse ekleme yapcaktık
                {
                    UpdatePersonel();  //methodu çağırıyorum ki update etsin tabloyu
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePersonel();
            MessageBox.Show("User list updated successfully!!");
        }

        
    }
}
