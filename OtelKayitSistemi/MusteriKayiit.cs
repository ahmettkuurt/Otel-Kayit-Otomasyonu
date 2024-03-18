using CefSharp.DevTools.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelKayitSistemi
{
	class MusteriKayiit
	{
		public string kisi_Adi_Soyadi_Getir { get; set; }


		public static void odaKayitAl(string odaAdi, string odaSahibi)
		{

			if (baglanti.connection.State == System.Data.ConnectionState.Open)
			{
				baglanti.connection.Close(); // bağlantı açıksa bağlantıyı kapat

			}

			try
			{
				baglanti.connection.Open(); // bağlantı aç
				SqlCommand kayitGuncelle = new SqlCommand("update odalar set odaSahibi=@alan_kisi,odaDurumu=@durum where odaAdi=@oda_adi", baglanti.connection);
				kayitGuncelle.Parameters.AddWithValue("@alan_kisi", odaSahibi);
				kayitGuncelle.Parameters.AddWithValue("@durum", "Dolu");
				kayitGuncelle.Parameters.AddWithValue("@oda_adi", odaAdi);
				kayitGuncelle.ExecuteNonQuery();
				kayitGuncelle.Dispose();
			}
			catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }
			finally
			{
				baglanti.connection.Close(); //  bağlantıyı kapat
			}
		}


		public void kayitAl(string ad, string soyad, string cinsiyet, string tc, string oda, string ucret, DateTime giris, DateTime cikis)
		{
			if (baglanti.connection.State == System.Data.ConnectionState.Open)
			{
				baglanti.connection	.Close(); // bağlantı açıksa bağlantıyı kapat
			}
			try
			{
				baglanti.connection.Open(); // bağlantıyı aç
				SqlCommand kayitEkle = new SqlCommand("insert into musteriler values(@ad,@soyad,@cinsiyet,@tcNo,@odaNo,@ucret,@girisTarih,@cikisTarih)",
				baglanti.connection); // insert ifadesi yazılacak
				kayitEkle.Parameters.AddWithValue("@ad", ad); // parametreler üzerinde işlem yapılacak
				kayitEkle.Parameters.AddWithValue("@soyad", soyad);
				kayitEkle.Parameters.AddWithValue("@cinsiyet", cinsiyet);
				kayitEkle.Parameters.AddWithValue("@tcNo", tc);
				kayitEkle.Parameters.AddWithValue("@odaNo", oda);
				kayitEkle.Parameters.AddWithValue("@ucret", ucret);
				kayitEkle.Parameters.AddWithValue("@girisTarih", giris);
				kayitEkle.Parameters.AddWithValue("@cikisTarih", cikis);
				kayitEkle.ExecuteNonQuery(); // eklemeleri yap
				System.Windows.Forms.MessageBox.Show("Müşteri kaydınız tamamlandı : " + oda + " adlı oda " + ad + "  " + soyad + " adlı kişiye verilmiştir.", "Bilgilendirme Mesajı", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
				kayitEkle.Dispose(); // ram bellekten boşaltmaya yarar.

				kisi_Adi_Soyadi_Getir = ad + " " + soyad;
				odaKayitAl(oda, kisi_Adi_Soyadi_Getir);
			}
			catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }

			finally
			{
				baglanti.connection.Close(); // bağlantıyı kapat
			}

		}


	}
}
