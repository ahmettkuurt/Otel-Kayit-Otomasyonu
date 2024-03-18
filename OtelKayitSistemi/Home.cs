using CefSharp.DevTools.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OtelKayitSistemi
{
	class Home
	{
		public string kullaniciAdi_tut { get; set; }
		public string kullaniciSifre_tut { get; set; }

		public string girisDurumu { get; set; }

		public void Login(string kullaniciAdi, string kullaniciSifre, DateTime tarih)
		{

			if (baglanti.connection.State == System.Data.ConnectionState.Open)
			{
				baglanti.connection.Close();
			}

			try
			{
				baglanti.connection.Open();

				SqlCommand loginName = new SqlCommand("select kullaniciAdi from kullaniciBilgileri where kullaniciAdi=@kulAdi", baglanti.connection);
				loginName.Parameters.AddWithValue("@kulAdi", kullaniciAdi);
				SqlDataReader kulAdi_Oku = loginName.ExecuteReader();
				if (kulAdi_Oku.Read())
				{
					kullaniciAdi_tut = kulAdi_Oku["kullaniciAdi"].ToString();
					SqlCommand loginPw = new SqlCommand("select kullaniciSifre from kullaniciBilgileri where kullaniciSifre = @sifre", baglanti.connection);
					loginPw.Parameters.AddWithValue("@sifre", kullaniciSifre);
					SqlDataReader loginPw_Oku = loginPw.ExecuteReader();
					if (loginPw_Oku.Read())
					{
						kullaniciSifre_tut = loginPw_Oku["kullaniciSifre"].ToString();
						girisDurumu = kullaniciAdi_tut + " " + kullaniciSifre_tut;
						SqlCommand dateUpdate = new SqlCommand("update kullaniciBilgileri set girisTarihi=@tarih where kullaniciAdi = @kuladi AND kullaniciSifre = @kulsifre", baglanti.connection);
						dateUpdate.Parameters.AddWithValue("@tarih", tarih);
						dateUpdate.Parameters.AddWithValue("@kuladi", kullaniciAdi_tut);
						dateUpdate.Parameters.AddWithValue("@kulsifre", kullaniciSifre_tut);
						dateUpdate.ExecuteNonQuery();
						dateUpdate.Dispose();
					}
					else
					{
						MessageBox.Show("Kullanıcı şifreni yanlış girdin!", "Hata | Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					loginPw.Dispose();
					loginPw_Oku.Close();

				}
				else
				{
					MessageBox.Show("Kullanıcı adını yanlış girdin!", "Hata | Otel otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				loginName.Dispose();
				kulAdi_Oku.Close();
				baglanti.connection.Close();


			}
			catch
			{

			}
			finally
			{
				baglanti.connection.Close();
			}
		}
	}
}
