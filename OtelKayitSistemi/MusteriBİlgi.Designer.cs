namespace OtelKayitSistemi
{
	partial class MusteriBİlgi
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriBİlgi));
			this.lblId = new System.Windows.Forms.Label();
			this.txtAra = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dateCikisi = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dateGirisi = new System.Windows.Forms.DateTimePicker();
			this.txtUcreti = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtOdasi = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTcsi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbCinsiyeti = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSoyadi = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAdi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnArama = new System.Windows.Forms.Button();
			this.btnAlanTemizle = new System.Windows.Forms.Button();
			this.btnVeriGetir = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.otelKayitSistemiDataSet = new OtelKayitSistemi.OtelKayitSistemiDataSet();
			this.otelKayitSistemiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.otelKayitSistemiDataSet1 = new OtelKayitSistemi.OtelKayitSistemiDataSet1();
			this.otelKayitSistemiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.musterilerTableAdapter = new OtelKayitSistemi.OtelKayitSistemiDataSet1TableAdapters.musterilerTableAdapter();
			this.musteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.odaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.girisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cikisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.otelKayitSistemiDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.otelKayitSistemiDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.otelKayitSistemiDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.otelKayitSistemiDataSet1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(12, 193);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(35, 13);
			this.lblId.TabIndex = 82;
			this.lblId.Text = "NULL";
			this.lblId.Visible = false;
			this.lblId.Click += new System.EventHandler(this.lblId_Click);
			// 
			// txtAra
			// 
			this.txtAra.Location = new System.Drawing.Point(68, 149);
			this.txtAra.Name = "txtAra";
			this.txtAra.Size = new System.Drawing.Size(100, 20);
			this.txtAra.TabIndex = 80;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(13, 152);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(28, 13);
			this.label9.TabIndex = 79;
			this.label9.Text = "AD :";
			// 
			// dateCikisi
			// 
			this.dateCikisi.Location = new System.Drawing.Point(533, 50);
			this.dateCikisi.Name = "dateCikisi";
			this.dateCikisi.Size = new System.Drawing.Size(168, 20);
			this.dateCikisi.TabIndex = 73;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(465, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 13);
			this.label8.TabIndex = 72;
			this.label8.Text = "ÇIKIŞ :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(465, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 71;
			this.label7.Text = "GİRİŞ  :";
			// 
			// dateGirisi
			// 
			this.dateGirisi.Location = new System.Drawing.Point(533, 12);
			this.dateGirisi.Name = "dateGirisi";
			this.dateGirisi.Size = new System.Drawing.Size(168, 20);
			this.dateGirisi.TabIndex = 70;
			// 
			// txtUcreti
			// 
			this.txtUcreti.Location = new System.Drawing.Point(336, 65);
			this.txtUcreti.Name = "txtUcreti";
			this.txtUcreti.Size = new System.Drawing.Size(100, 20);
			this.txtUcreti.TabIndex = 69;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(252, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 13);
			this.label6.TabIndex = 68;
			this.label6.Text = "ÜCRET :";
			// 
			// txtOdasi
			// 
			this.txtOdasi.Location = new System.Drawing.Point(336, 34);
			this.txtOdasi.Name = "txtOdasi";
			this.txtOdasi.Size = new System.Drawing.Size(100, 20);
			this.txtOdasi.TabIndex = 67;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(252, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 13);
			this.label5.TabIndex = 66;
			this.label5.Text = "ALINAN ODA :";
			// 
			// txtTcsi
			// 
			this.txtTcsi.Location = new System.Drawing.Point(336, 5);
			this.txtTcsi.Name = "txtTcsi";
			this.txtTcsi.Size = new System.Drawing.Size(100, 20);
			this.txtTcsi.TabIndex = 65;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(255, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 64;
			this.label4.Text = "TC NO :";
			// 
			// cbCinsiyeti
			// 
			this.cbCinsiyeti.FormattingEnabled = true;
			this.cbCinsiyeti.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
			this.cbCinsiyeti.Location = new System.Drawing.Point(88, 64);
			this.cbCinsiyeti.Name = "cbCinsiyeti";
			this.cbCinsiyeti.Size = new System.Drawing.Size(100, 21);
			this.cbCinsiyeti.TabIndex = 63;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 62;
			this.label3.Text = "CİNSİYET :";
			// 
			// txtSoyadi
			// 
			this.txtSoyadi.Location = new System.Drawing.Point(88, 31);
			this.txtSoyadi.Name = "txtSoyadi";
			this.txtSoyadi.Size = new System.Drawing.Size(100, 20);
			this.txtSoyadi.TabIndex = 61;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 60;
			this.label2.Text = "SOYAD :";
			// 
			// txtAdi
			// 
			this.txtAdi.Location = new System.Drawing.Point(88, 5);
			this.txtAdi.Name = "txtAdi";
			this.txtAdi.Size = new System.Drawing.Size(100, 20);
			this.txtAdi.TabIndex = 59;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 58;
			this.label1.Text = "AD :";
			// 
			// btnSil
			// 
			this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
			this.btnSil.Location = new System.Drawing.Point(444, 105);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(109, 119);
			this.btnSil.TabIndex = 75;
			this.btnSil.Text = "sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnArama
			// 
			this.btnArama.Image = ((System.Drawing.Image)(resources.GetObject("btnArama.Image")));
			this.btnArama.Location = new System.Drawing.Point(209, 105);
			this.btnArama.Name = "btnArama";
			this.btnArama.Size = new System.Drawing.Size(113, 121);
			this.btnArama.TabIndex = 81;
			this.btnArama.UseVisualStyleBackColor = true;
			this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
			// 
			// btnAlanTemizle
			// 
			this.btnAlanTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnAlanTemizle.Image")));
			this.btnAlanTemizle.Location = new System.Drawing.Point(682, 105);
			this.btnAlanTemizle.Name = "btnAlanTemizle";
			this.btnAlanTemizle.Size = new System.Drawing.Size(113, 119);
			this.btnAlanTemizle.TabIndex = 77;
			this.btnAlanTemizle.UseVisualStyleBackColor = true;
			this.btnAlanTemizle.Click += new System.EventHandler(this.btnAlanTemizle_Click);
			// 
			// btnVeriGetir
			// 
			this.btnVeriGetir.Image = ((System.Drawing.Image)(resources.GetObject("btnVeriGetir.Image")));
			this.btnVeriGetir.Location = new System.Drawing.Point(559, 106);
			this.btnVeriGetir.Name = "btnVeriGetir";
			this.btnVeriGetir.Size = new System.Drawing.Size(117, 118);
			this.btnVeriGetir.TabIndex = 76;
			this.btnVeriGetir.UseVisualStyleBackColor = true;
			this.btnVeriGetir.Click += new System.EventHandler(this.btnVeriGetir_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
			this.btnGuncelle.Location = new System.Drawing.Point(328, 106);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(110, 118);
			this.btnGuncelle.TabIndex = 74;
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// otelKayitSistemiDataSet
			// 
			this.otelKayitSistemiDataSet.DataSetName = "OtelKayitSistemiDataSet";
			this.otelKayitSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// otelKayitSistemiDataSetBindingSource
			// 
			this.otelKayitSistemiDataSetBindingSource.DataSource = this.otelKayitSistemiDataSet;
			this.otelKayitSistemiDataSetBindingSource.Position = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Aquamarine;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tcNoDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.odaNoDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.girisTarihDataGridViewTextBoxColumn,
            this.cikisTarihDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.musterilerBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(-2, 230);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(942, 150);
			this.dataGridView1.TabIndex = 83;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
			// 
			// otelKayitSistemiDataSet1
			// 
			this.otelKayitSistemiDataSet1.DataSetName = "OtelKayitSistemiDataSet1";
			this.otelKayitSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// otelKayitSistemiDataSet1BindingSource
			// 
			this.otelKayitSistemiDataSet1BindingSource.DataSource = this.otelKayitSistemiDataSet1;
			this.otelKayitSistemiDataSet1BindingSource.Position = 0;
			// 
			// musterilerBindingSource
			// 
			this.musterilerBindingSource.DataMember = "musteriler";
			this.musterilerBindingSource.DataSource = this.otelKayitSistemiDataSet1BindingSource;
			// 
			// musterilerTableAdapter
			// 
			this.musterilerTableAdapter.ClearBeforeFill = true;
			// 
			// musteriIDDataGridViewTextBoxColumn
			// 
			this.musteriIDDataGridViewTextBoxColumn.DataPropertyName = "MusteriID";
			this.musteriIDDataGridViewTextBoxColumn.FillWeight = 50F;
			this.musteriIDDataGridViewTextBoxColumn.HeaderText = "MusteriID";
			this.musteriIDDataGridViewTextBoxColumn.Name = "musteriIDDataGridViewTextBoxColumn";
			this.musteriIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// adDataGridViewTextBoxColumn
			// 
			this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
			this.adDataGridViewTextBoxColumn.HeaderText = "ad";
			this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
			// 
			// soyadDataGridViewTextBoxColumn
			// 
			this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
			this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
			this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
			// 
			// tcNoDataGridViewTextBoxColumn
			// 
			this.tcNoDataGridViewTextBoxColumn.DataPropertyName = "tcNo";
			this.tcNoDataGridViewTextBoxColumn.HeaderText = "tcNo";
			this.tcNoDataGridViewTextBoxColumn.Name = "tcNoDataGridViewTextBoxColumn";
			// 
			// cinsiyetDataGridViewTextBoxColumn
			// 
			this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
			this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "cinsiyet";
			this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
			// 
			// odaNoDataGridViewTextBoxColumn
			// 
			this.odaNoDataGridViewTextBoxColumn.DataPropertyName = "odaNo";
			this.odaNoDataGridViewTextBoxColumn.HeaderText = "odaNo";
			this.odaNoDataGridViewTextBoxColumn.Name = "odaNoDataGridViewTextBoxColumn";
			// 
			// ucretDataGridViewTextBoxColumn
			// 
			this.ucretDataGridViewTextBoxColumn.DataPropertyName = "ucret";
			this.ucretDataGridViewTextBoxColumn.HeaderText = "ucret";
			this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
			// 
			// girisTarihDataGridViewTextBoxColumn
			// 
			this.girisTarihDataGridViewTextBoxColumn.DataPropertyName = "girisTarih";
			this.girisTarihDataGridViewTextBoxColumn.HeaderText = "girisTarih";
			this.girisTarihDataGridViewTextBoxColumn.Name = "girisTarihDataGridViewTextBoxColumn";
			// 
			// cikisTarihDataGridViewTextBoxColumn
			// 
			this.cikisTarihDataGridViewTextBoxColumn.DataPropertyName = "cikisTarih";
			this.cikisTarihDataGridViewTextBoxColumn.HeaderText = "cikisTarih";
			this.cikisTarihDataGridViewTextBoxColumn.Name = "cikisTarihDataGridViewTextBoxColumn";
			// 
			// MusteriBİlgi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(938, 436);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.btnArama);
			this.Controls.Add(this.txtAra);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnAlanTemizle);
			this.Controls.Add(this.btnVeriGetir);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.dateCikisi);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dateGirisi);
			this.Controls.Add(this.txtUcreti);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtOdasi);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTcsi);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbCinsiyeti);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSoyadi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAdi);
			this.Controls.Add(this.label1);
			this.Name = "MusteriBİlgi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MusteriBİlgi";
			this.Load += new System.EventHandler(this.MusteriBİlgi_Load);
			((System.ComponentModel.ISupportInitialize)(this.otelKayitSistemiDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.otelKayitSistemiDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.otelKayitSistemiDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.otelKayitSistemiDataSet1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Button btnArama;
		private System.Windows.Forms.TextBox txtAra;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnAlanTemizle;
		private System.Windows.Forms.Button btnVeriGetir;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.DateTimePicker dateCikisi;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dateGirisi;
		private System.Windows.Forms.TextBox txtUcreti;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtOdasi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTcsi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbCinsiyeti;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSoyadi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAdi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource otelKayitSistemiDataSetBindingSource;
		private OtelKayitSistemiDataSet otelKayitSistemiDataSet;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource otelKayitSistemiDataSet1BindingSource;
		private OtelKayitSistemiDataSet1 otelKayitSistemiDataSet1;
		private System.Windows.Forms.BindingSource musterilerBindingSource;
		private OtelKayitSistemiDataSet1TableAdapters.musterilerTableAdapter musterilerTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tcNoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn odaNoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihDataGridViewTextBoxColumn;
	}
}