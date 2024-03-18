using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelKayitSistemi
{
	public partial class Ayarlar : Form
	{
		public Ayarlar()
		{
			InitializeComponent();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			baglanti.CheckConnection();
			SqlCommand cmd = new SqlCommand("update Personel set Kadi=@kadi ,Sifre=@sifre where PersonelID="+1, baglanti.connection);
			cmd.Parameters.AddWithValue("@kadi", txtkadi.Text);
			cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
			cmd.ExecuteNonQuery();
			cmd.Dispose();
			MessageBox.Show("Kullanıcı Adı ve Şifre Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Anasayfa a = new Anasayfa();
			a.Show();
			this.Hide();
			baglanti.connection.Close();
		}
	}
}
