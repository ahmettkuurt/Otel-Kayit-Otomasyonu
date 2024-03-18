using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelKayitSistemi.Haberler
{
	public partial class Haber : Form
	{
		public Haber()
		{
			InitializeComponent();
		}

		private void Haberler_Load(object sender, EventArgs e)
		{

		}

		private void Haber7_Click(object sender, EventArgs e)
		{
			bool kontrol = İnternetKontrol.internetcheck();

			if (kontrol == true)
			{
				Haber7 h = new Haber7();
				h.Show();
			}
			else
			{
				MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		private void TrtHaber_Click(object sender, EventArgs e)
		{
			bool kontrol = İnternetKontrol.internetcheck();

			if (kontrol == true)
			{
				TrtHaber t = new TrtHaber();
				t.Show();
			}
			else
			{
				MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		private void Haberler_com_Click(object sender, EventArgs e)
		{
			bool kontrol = İnternetKontrol.internetcheck();

			if (kontrol == true)
			{
				Haber_com hc = new Haber_com();
				hc.Show();
			}
			else
			{
				MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		private void Ensonhaber_Click(object sender, EventArgs e)
		{
			bool kontrol = İnternetKontrol.internetcheck();

			if (kontrol == true)
			{
				EnSonHaber esh = new EnSonHaber();
				esh.Show();
			}
			else
			{
				MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		private void Hürriyet_Click(object sender, EventArgs e)
		{
			bool kontrol = İnternetKontrol.internetcheck();

			if (kontrol == true)
			{
				Hürriyet hü = new Hürriyet();
				hü.Show();
			}
			else
			{
				MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		private void Milliyet_Click(object sender, EventArgs e)
		{
			bool kontrol = İnternetKontrol.internetcheck();

			if (kontrol == true)
			{
				Milliyet milliyet = new Milliyet();
				milliyet.Show();
			}
			else
			{
				MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
	}
}
