using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OtelKayitSistemi
{
	public class baglanti
	{
		public static SqlConnection connection = new SqlConnection("Data Source=AHMET\\SQLEXPRESS;Initial Catalog=OtelKayitSistemi;Integrated Security=True");

		public static void CheckConnection()
		{
			if (connection.State == System.Data.ConnectionState.Closed)
			{
				connection.Open();
			}
		}
	}
}
