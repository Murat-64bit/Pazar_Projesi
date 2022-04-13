using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PazarProjesi
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-F24NTQI;Initial Catalog=DbPazar;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
