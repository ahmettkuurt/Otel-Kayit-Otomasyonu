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
	public partial class MusteriBİlgi : Form
	{
		public MusteriBİlgi()
		{
			InitializeComponent();
		}

		private void btnArama_Click(object sender, EventArgs e)
		{
			MüşteriEkranı me = new MüşteriEkranı();
			dataGridView1.DataSource = me.musterilerAra(txtAra.Text);
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			DateTime girisTarih = Convert.ToDateTime(dateGirisi.Value);
			DateTime cikisTarih = Convert.ToDateTime(dateCikisi.Value);
			int id = Convert.ToInt32(lblId.Text);
			MüşteriEkranı me = new MüşteriEkranı();
			me.musterileriGuncelle(id, txtAdi.Text, txtSoyadi.Text, cbCinsiyeti.Text, txtTcsi.Text, txtOdasi.Text, txtUcreti.Text, girisTarih, cikisTarih);
			dataGridView1.DataSource = me.tablolar();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(lblId.Text);
			String oda_adi = txtOdasi.Text;

			MüşteriEkranı me = new MüşteriEkranı();
			me.musterilerSil(id, oda_adi);
			dataGridView1.DataSource = me.tablolar();
		}

		private void btnVeriGetir_Click(object sender, EventArgs e)
		{
			lblId.Text =dataGridView1.CurrentRow.Cells[0].Value.ToString();
			txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			cbCinsiyeti.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			txtTcsi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			txtOdasi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			txtUcreti.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			dateGirisi.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());
			dateCikisi.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[8].Value.ToString());
			MüşteriEkranı müşteriEkranı = new MüşteriEkranı();
			dataGridView1.DataSource = müşteriEkranı.tablolar();
		}

		private void btnAlanTemizle_Click(object sender, EventArgs e)
		{
			txtAdi.Text = "";
			txtSoyadi.Text = "";
			cbCinsiyeti.Text = "";
			txtTcsi.Text = "";
			txtOdasi.Text = "";
			txtUcreti.Text = "";
			dateGirisi.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
			dateCikisi.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lblId.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
			txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			cbCinsiyeti.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			txtTcsi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			txtOdasi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			txtUcreti.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			dateGirisi.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());
			dateCikisi.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[8].Value.ToString());
		}

		private void lblId_Click(object sender, EventArgs e)
		{

		}

		private void MusteriBİlgi_Load(object sender, EventArgs e)
		{


		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
