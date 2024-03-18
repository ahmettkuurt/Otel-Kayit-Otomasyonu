namespace OtelKayitSistemi
{
	partial class Anasayfa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
			this.youtube = new System.Windows.Forms.Button();
			this.btnayarlar = new System.Windows.Forms.Button();
			this.btnmusteri = new System.Windows.Forms.Button();
			this.btnhaber = new System.Windows.Forms.Button();
			this.btnInstagram = new System.Windows.Forms.Button();
			this.btnkayit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// youtube
			// 
			this.youtube.Image = global::OtelKayitSistemi.Properties.Resources.icons8_youtube_48;
			this.youtube.Location = new System.Drawing.Point(273, 48);
			this.youtube.Name = "youtube";
			this.youtube.Size = new System.Drawing.Size(159, 140);
			this.youtube.TabIndex = 2;
			this.youtube.Text = "Youtube";
			this.youtube.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.youtube.UseVisualStyleBackColor = true;
			this.youtube.Click += new System.EventHandler(this.youtube_Click);
			// 
			// btnayarlar
			// 
			this.btnayarlar.Image = global::OtelKayitSistemi.Properties.Resources.Settings;
			this.btnayarlar.Location = new System.Drawing.Point(483, 236);
			this.btnayarlar.Name = "btnayarlar";
			this.btnayarlar.Size = new System.Drawing.Size(159, 140);
			this.btnayarlar.TabIndex = 1;
			this.btnayarlar.Text = "Ayarlar";
			this.btnayarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnayarlar.UseVisualStyleBackColor = true;
			this.btnayarlar.Click += new System.EventHandler(this.btnayarlar_Click);
			// 
			// btnmusteri
			// 
			this.btnmusteri.Image = global::OtelKayitSistemi.Properties.Resources.icons8_male_user_50;
			this.btnmusteri.Location = new System.Drawing.Point(59, 236);
			this.btnmusteri.Name = "btnmusteri";
			this.btnmusteri.Size = new System.Drawing.Size(159, 140);
			this.btnmusteri.TabIndex = 1;
			this.btnmusteri.Text = "Müşteri Bilgleri";
			this.btnmusteri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnmusteri.UseVisualStyleBackColor = true;
			this.btnmusteri.Click += new System.EventHandler(this.btnmusteri_Click);
			// 
			// btnhaber
			// 
			this.btnhaber.Image = global::OtelKayitSistemi.Properties.Resources.News;
			this.btnhaber.Location = new System.Drawing.Point(273, 236);
			this.btnhaber.Name = "btnhaber";
			this.btnhaber.Size = new System.Drawing.Size(159, 140);
			this.btnhaber.TabIndex = 0;
			this.btnhaber.Text = "Haberler";
			this.btnhaber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnhaber.UseVisualStyleBackColor = true;
			this.btnhaber.Click += new System.EventHandler(this.btnhaber_Click);
			// 
			// btnInstagram
			// 
			this.btnInstagram.Image = global::OtelKayitSistemi.Properties.Resources.Instagram;
			this.btnInstagram.Location = new System.Drawing.Point(483, 48);
			this.btnInstagram.Name = "btnInstagram";
			this.btnInstagram.Size = new System.Drawing.Size(159, 140);
			this.btnInstagram.TabIndex = 0;
			this.btnInstagram.Text = "İnstagram";
			this.btnInstagram.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnInstagram.UseVisualStyleBackColor = true;
			this.btnInstagram.Click += new System.EventHandler(this.btnInstagram_Click);
			// 
			// btnkayit
			// 
			this.btnkayit.Image = global::OtelKayitSistemi.Properties.Resources.icons8_add_male_user_50;
			this.btnkayit.Location = new System.Drawing.Point(59, 48);
			this.btnkayit.Name = "btnkayit";
			this.btnkayit.Size = new System.Drawing.Size(159, 140);
			this.btnkayit.TabIndex = 0;
			this.btnkayit.Text = "Müşteri Kayıt";
			this.btnkayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnkayit.UseVisualStyleBackColor = true;
			this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
			// 
			// Anasayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(700, 428);
			this.Controls.Add(this.youtube);
			this.Controls.Add(this.btnayarlar);
			this.Controls.Add(this.btnmusteri);
			this.Controls.Add(this.btnhaber);
			this.Controls.Add(this.btnInstagram);
			this.Controls.Add(this.btnkayit);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Anasayfa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Anasayfa";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnkayit;
		private System.Windows.Forms.Button btnmusteri;
		private System.Windows.Forms.Button btnInstagram;
		private System.Windows.Forms.Button btnhaber;
		private System.Windows.Forms.Button btnayarlar;
		private System.Windows.Forms.Button youtube;
	}
}