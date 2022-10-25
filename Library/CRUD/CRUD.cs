using Library.Sql_Connections;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.CRUD
{
    public class CRUD
    {
        static DataTable dt; //DataTable -> represents one table of in memory data -- sadece burdaki class içinde kullanacağımız için static

        public static DataTable List(string sql) //sqlite deki veri tabanım geliyor
        {
            dt = new DataTable();   //personel listesini formda oluştumak için table oluşturuyoruz

           //the SqlDataAdapter, serves as a bridge between a dataSet and SQL server for retvieving and saving data
            SQLiteDataAdapter adptr = new SQLiteDataAdapter(sql, Connect.connection);  //yukarda oluşturduğumuz table
                                                                                       //ve sqlite da oluşturduğumuz tabloyu (connect sınıfında connection objesinde sqlite ile bağlamıştık) CRUD da alıp buna yolluyoruz

            adptr.Fill(dt); //verileri de datatable ye dolduruyoruz
            return dt;
        }


        //ekleme silme ve güncelleme işlerini yapacak method oluşturuyoruz
        public static bool Crud(string sql)  //(SQLİTE programını açıp kapatarak gerekli bilgileri eklicek ya da düzenlicek) (bunu personel ekle/sil yaparken çağırıcaz)
        {
            int b = 0;
            SQLiteCommand cmd = new SQLiteCommand(sql, Connect.connection);  //Connect.connection diyerek bağlantıyı çağırıyorz

            Connect.connection.Open();  //Bağlantıyı açıp bir şeyler ekleyip sora kapatıcaz bağlantıyı
            b = cmd.ExecuteNonQuery(); //eğer sıfırdan farklı bir değer alırsa sorgusu yapabilmek için
            Connect.connection.Close();

            if (b == 0) { return false; } //dönüş olarak false giderse frmPersonelCrud da düzenleme 
            else { return true; }   //true giderse ekleme yapıcaz
        }
    }
}
