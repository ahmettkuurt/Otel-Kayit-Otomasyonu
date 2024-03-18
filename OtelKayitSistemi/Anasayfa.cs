using OtelKayitSistemi.Haberler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelKayitSistemi
{
	public partial class Anasayfa : Form
	{
		public Anasayfa()
		{
			InitializeComponent();
		}

		private void pcsettings_Click(object sender, EventArgs e)
		{
			Ayarlar s = new Ayarlar();
			s.Show();
		}

		private void btnInstagram_Click(object sender, EventArgs e)
		{
			bool kontrol = İnternetKontrol.internetcheck();

			if (kontrol == true)
			{
				Instagram y = new Instagram();
				y.Show();
			}
			else
			{
				MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		private void btnmusteri_Click(object sender, EventArgs e)
		{
			MusteriBİlgi mb = new MusteriBİlgi();
			mb.Show();
		}

		private void btnkayit_Click(object sender, EventArgs e)
		{
			MusteriKayit mk = new MusteriKayit();
			mk.Show();
		}

		private void btnhaber_Click(object sender, EventArgs e)
		{
			Haber h = new Haber();
			h.Show();
		}

		private void youtube_Click(object sender, EventArgs e)
		{
			bool kontrol = İnternetKontrol.internetcheck();

			if (kontrol == true)
			{
				Youtube yy = new Youtube();
				yy.Show();
			}
			else
			{
				MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		private void btnayarlar_Click(object sender, EventArgs e)
		{
			Ayarlar aa= new Ayarlar();
			aa.Show();
		}
	}
}
