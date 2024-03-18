using CefSharp.DevTools.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelKayitSistemi
{
	class Odalaar
	{
		public string buyPerson { get; set; }
		public string state { get; set; }
		public string buttonAdi { get; set; }

		Database database = new Database();

		public void odaDeger(string odaAdi, string durum) // metod tanımı
		{
			if (baglanti.connection.State == System.Data.ConnectionState.Open)
			{
				baglanti.connection.Close();
			}

			try
			{
				baglanti.connection.Open();
				SqlCommand odalariAl = new SqlCommand("select * from odalar where odaAdi=@odaAdi and odaDurumu=@odaDurumu", baglanti.connection);
				odalariAl.Parameters.AddWithValue("@odaAdi", odaAdi);
				odalariAl.Parameters.AddWithValue("@odaDurumu", durum);
				SqlDataReader odalari_Oku = odalariAl.ExecuteReader();

				if (odalari_Oku.Read())
				{
					buyPerson = odalari_Oku["odaSahibi"].ToString();
					state = odalari_Oku["odaDurumu"].ToString();
					buttonAdi = odalari_Oku["buttonName"].ToString();

				}

				odalariAl.Dispose();
				odalari_Oku.Close();

			}
			catch (Exception hata)
			{
				System.Windows.Forms.MessageBox.Show("" + hata);
			}
			finally
			{
				baglanti.connection.Close();
			}
		}


		public void oda_kayitAl(string odaAdi, string odaSahibi, string odaDurumu, string buttonName)
		{
			if (baglanti.connection.State == System.Data.ConnectionState.Open)
			{
				baglanti.connection.Close(); // bağlantı açıksa bağlantıyı kapat
			}
			try
			{
				baglanti.connection.Open(); // bağlantıyı aç
				SqlCommand oda_kayitEkle = new SqlCommand("insert into odalar values(@odaAdi,@odaSahibi,@odaDurumu,@buttonName)",
				baglanti.connection); // insert ifadesi yazılacak
				oda_kayitEkle.Parameters.AddWithValue("@odaAdi", odaAdi); // parametreler üzerinde işlem yapılacak
				oda_kayitEkle.Parameters.AddWithValue("@odaSahibi", odaSahibi);
				oda_kayitEkle.Parameters.AddWithValue("@odaDurumu", odaDurumu);
				oda_kayitEkle.Parameters.AddWithValue("@buttonName", buttonName);
				oda_kayitEkle.ExecuteNonQuery(); // eklemeleri yap
				oda_kayitEkle.Dispose(); // ram bellekten boşaltmaya yarar.


			}
			catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }

			finally
			{
				baglanti.connection	.Close(); // bağlantıyı kapat
			}

		}
	}
}
