using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library.Forms
{
    public partial class frmSavePersonel : Form
    {

        int? id = null; //her yerde kullanabilmek için dışarda tanımladık (id null olabilir diyoruz ? yaparak)
        public bool okey = false;  //başarıyla gerçekleşirse bunu btnPersonelSavede true yapıp diğer sınıflarda if (frm.okey == true) sorgusu yaparak sayfayı(tabloyu) update ettircez

        public frmSavePersonel(int? Id = null)
        {
            InitializeComponent();
            if (Id != null) //null ise (ekleme)kaydetme - null değilse güncelleme yapıcaz
            {
                this.id = Id;
            }
        }

        private void frmSavePersonel_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonelCreate_Click(object sender, EventArgs e)
        {

            if (id == null) //id boşsa ekleme doluysa güncelleme yapılcak
            {

                //id i getirmeye gerek yok ondan parantez içinde tek tek alcağımız değerleri yazdık
                string sql = "Insert into information(First_And_Last_Name, Telephone_No, Mail, Password) Values (' " + txtName.Text + " ' , '" + txtTelephone.Text + "' , '" + txtMail.Text + "' , '" + txtPassword.Text + "'  ) ";

                if (CRUD.CRUD.Crud(sql) == true)  //ykarda sqlite dan tablo verilerine alıyoruz burda crud işlemlerini yapsın diye aldığımız verileri CRUD sınıfının Crud methodunda yeni personel eklensin diye yolluyoruz(null ise yeni ekleniyordu)
                {
                    okey = true;
                    MessageBox.Show("New person added successfully!"); //işlemin başarıyla gerçekleştiğini belirtmek için
                    this.Close();    //form u kapatsın diye
                }
            }
            else //dolu olduğu için güncelleme yapılcak
            {
                //güncelleme yapcağımız için güncellencek bilgileri update information set yapıyoruz where yani nereye göre-> Id ye göre(global alandaki id olan)
                string sql = "Update information set First_And_Last_Name='" + txtName.Text + "' ,Telephone_No= '" + txtTelephone.Text + "' , Mail='" + txtMail.Text + "' ,Password= '" + txtPassword.Text + "' Where Id= '" + id + "'   ";
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
