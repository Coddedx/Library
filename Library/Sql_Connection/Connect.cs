using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Sql_Connections
{
    public class Connect
    {
               ////sqliteconnection ile ilgili referansı ekliyoruz - bin dosyası içine sqlite da oluşturduğumuz veritabanını yazdık(adı)
        public static SQLiteConnection connection = new SQLiteConnection("Data Source=.\\Library2DB.db;"); //nesne türetmeye gerek kalmadan kullanalım diye static
    }
}
