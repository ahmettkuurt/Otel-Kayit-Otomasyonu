using CefSharp.DevTools.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelKayitSistemi
{
	class MüşteriEkranı
	{


		public string state { get; set; }

		public string deleteState { get; set; }

		public DataTable tablolar()
		{
			if (baglanti.connection.State == ConnectionState.Open)
			{
				baglanti.connection.Close();
			}

			try
			{
				baglanti.connection.Open();
				SqlCommand verileriAl = new SqlCommand("select * from musteriler", baglanti.connection);
				SqlDataAdapter adapter = new SqlDataAdapter(verileriAl); // tablodaki verileri saklama yapıyor
				DataTable dataTable = new DataTable(); // tabloda verileri eşleme yapıyor
				adapter.Fill(dataTable); // datatable adapter eklendi
				return dataTable; // datatable döndürme işlemi yapılıyor

			}
			catch
			{
				return null;
			}
			finally
			{
				baglanti.connection.Close();
			}
		}

		public void musterileriGuncelle(int id, string ad, string soyad, string cinsiyet, string tc, string oda, string ucret, DateTime giris, DateTime cikis)
		{
			if (baglanti.connection.State == ConnectionState.Open)
			{
				baglanti.connection.Close();
			}

			try
			{
				baglanti.connection.Open();

				SqlCommand update = new SqlCommand("update musteriler set ad=@ad,soyad=@soyad,cinsiyet=@cinsiyet,tcNo=@tcNo,odaNo=@odaNo,ucret=@ucret,girisTarih=@girisTarih,cikisTarih=@cikisTarih where MusteriID=@id", baglanti.connection);
				update.Parameters.AddWithValue("@id", id);
				update.Parameters.AddWithValue("@ad", ad);
				update.Parameters.AddWithValue("@soyad", soyad);
				update.Parameters.AddWithValue("@cinsiyet", cinsiyet);
				update.Parameters.AddWithValue("@tcNo", tc);
				update.Parameters.AddWithValue("@odaNo", oda);
				update.Parameters.AddWithValue("@ucret", ucret);
				update.Parameters.AddWithValue("@girisTarih", giris);
				update.Parameters.AddWithValue("@cikisTarih", cikis);
				update.ExecuteNonQuery();
				state = ad + " " + soyad + "isim ve soyisimli kişilerinin verileri güncellendi";


			}
			catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }
			finally
			{
				baglanti.connection.Close();
			}

		}

		public void musterilerSil(int id, String oda_adi)
		{
			if (baglanti.connection.State == ConnectionState.Open)
			{
				baglanti.connection.Close();
			}

			try
			{
				baglanti.connection.Open();
				SqlCommand delete = new SqlCommand("delete musteriler where MusteriID=@id", baglanti.connection);
				delete.Parameters.AddWithValue("@id", id);
				delete.ExecuteNonQuery();
				deleteState = "Silme işlemi başarılı bir şekilde gerçekleşti.";


				SqlCommand oda_delete = new SqlCommand("delete odalar where odaAdi=@ad", baglanti.connection);
				oda_delete.Parameters.AddWithValue("@ad", oda_adi);
				oda_delete.ExecuteNonQuery();


			}
			catch
			{

			}
			finally
			{
				baglanti.connection.Close();
			}
		}

		public DataTable musterilerAra(string ad)
		{
			if (baglanti.connection.State == ConnectionState.Open)
			{
				baglanti.connection.Close();
			}

			try
			{
				baglanti.connection.Open();
				SqlCommand search = new SqlCommand("select * from musteriler where ad LIKE'%'+@ad+'%'", baglanti.connection);
				search.Parameters.AddWithValue("@ad", ad);
				SqlDataAdapter adapter = new SqlDataAdapter(search);
				DataTable tablo = new DataTable();
				adapter.Fill(tablo);
				return tablo;





			}
			catch
			{
				return null;
			}
			finally
			{
				baglanti.connection.Close();
			}
		}

	}
}
