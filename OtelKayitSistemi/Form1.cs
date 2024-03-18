using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelKayitSistemi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btngiris_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("select*from Personel where Kadi=@kadi and Sifre=@sifre",baglanti.connection);
			baglanti.CheckConnection();
			cmd.Parameters.AddWithValue("@kadi", txtkadi.Text);
			cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
			SqlDataReader reader = cmd.ExecuteReader();
			if(reader.Read())
			{
				MessageBox.Show("Hoş Geldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Anasayfa a = new Anasayfa();
				a.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			baglanti.connection.Close();



		}
	}
}
