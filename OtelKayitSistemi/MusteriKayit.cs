﻿using CefSharp.DevTools.Database;
using System;
using System.Collections;
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
	public partial class MusteriKayit : Form
	{
		Button seciliButon;

		public MusteriKayit()
		{
			InitializeComponent();
		}

		ArrayList odalar = new ArrayList();

		void koltukYaz()
		{
			string oda = "";

			for (int i = 0; i < odalar.Count; i++)
			{
				oda += odalar[i].ToString() + " ,";
			}

			if (odalar.Count >= 1)
			{
				oda = oda.Remove(oda.Length - 1, 1);
			}
			txtOda.Text = oda;
		}

		private void odalaraTikla(object sender, EventArgs e)
		{
			if (((Button)sender).BackColor == Color.Lime)
			{
				((Button)sender).BackColor = Color.Yellow;
				seciliButon = ((Button)sender);


				if (!odalar.Contains(((Button)sender).Text))
				{

					odalar.Add(((Button)sender).Text);
				}
				koltukYaz();
			}
			else if (((Button)sender).BackColor == Color.Yellow)
			{
				((Button)sender).BackColor = Color.Lime;

				if (odalar.Contains(((Button)sender).Text))
				{
					odalar.Remove(((Button)sender).Text);

				}
				koltukYaz();
			}
		}

		public DateTime girisTarihi { get; set; }
		public DateTime cikisTarihi { get; set; }

		private void button1_Click(object sender, EventArgs e)
		{
			girisTarihi = Convert.ToDateTime(dateGiris.Value);
			cikisTarihi = Convert.ToDateTime(dateCikis.Value);
			MusteriKayiit kayit = new MusteriKayiit();

			for (int i = 0; i < odalar.Count; i++)
			{


				string room = odalar[i].ToString();
				kayit.kayitAl(txtAd.Text, txtSoyad.Text, cbCinsiyet.Text, txtTc.Text, room, txtUcret.Text, girisTarihi, cikisTarihi);

			}
			timer1.Start();

			seciliButon.BackColor = Color.Red;

			Odalaar odam = new Odalaar();
			odam.oda_kayitAl(seciliButon.Text, txtAd.Text + " " + txtSoyad.Text, "Dolu", seciliButon.Name);
			txtAd.Text = "";
			txtSoyad.Text = "";
			cbCinsiyet.Text = "";
			txtTc.Text = "";
			txtOda.Text = "";
			txtUcret.Text = "";
			dateGiris.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
			dateCikis.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());



		}

		private void MusteriKayit_Load(object sender, EventArgs e)
		{
			if (baglanti.connection.State == ConnectionState.Open)
			{
				baglanti.connection.Close();
			}


			try
			{
				baglanti.connection.Open();
				SqlCommand sqlCommand = new SqlCommand("select * from odalar where odaDurumu=@durum", baglanti.connection);
				sqlCommand.Parameters.AddWithValue("@durum", "Dolu");
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

				while (sqlDataReader.Read())
				{
					string buttonName = sqlDataReader["buttonName"].ToString();
					string odaDurumu = sqlDataReader["odaDurumu"].ToString();

					if (buttonName == "oda1" && odaDurumu == "Dolu")
					{
						oda1.BackColor = Color.Red;
					}

					if (buttonName == "oda2" && odaDurumu == "Dolu")
					{
						oda2.BackColor = Color.Red;
					}


					if (buttonName == "oda3" && odaDurumu == "Dolu")
					{
						oda3.BackColor = Color.Red;
					}

					if (buttonName == "oda4" && odaDurumu == "Dolu")
					{
						oda4.BackColor = Color.Red;
					}

					if (buttonName == "oda5" && odaDurumu == "Dolu")
					{
						oda5.BackColor = Color.Red;
					}

					if (buttonName == "oda6" && odaDurumu == "Dolu")
					{
						oda6.BackColor = Color.Red;
					}

					if (buttonName == "oda7" && odaDurumu == "Dolu")
					{
						oda7.BackColor = Color.Red;
					}

					if (buttonName == "oda8" && odaDurumu == "Dolu")
					{
						oda8.BackColor = Color.Red;
					}

					if (buttonName == "oda9" && odaDurumu == "Dolu")
					{
						oda9.BackColor = Color.Red;
					}

					if (buttonName == "oda10" && odaDurumu == "Dolu")
					{
						oda10.BackColor = Color.Red;
					}

					if (buttonName == "oda11" && odaDurumu == "Dolu")
					{
						oda11.BackColor = Color.Red;
					}

					if (buttonName == "oda12" && odaDurumu == "Dolu")
					{
						oda12.BackColor = Color.Red;
					}
				}

				sqlCommand.Dispose();
				sqlDataReader.Close();
				baglanti.connection.Close();
				timer1.Stop();

			}
			catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }
			finally
			{
				baglanti.connection.Close();
			}
		}
	}
}
