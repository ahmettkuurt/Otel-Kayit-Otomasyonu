namespace OtelKayitSistemi
{
	partial class Ayarlar
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtsifre = new System.Windows.Forms.TextBox();
			this.txtkadi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(29, 282);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 20);
			this.label2.TabIndex = 13;
			this.label2.Text = "Parola :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(29, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "Kullanıcı Adı :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtsifre
			// 
			this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtsifre.Location = new System.Drawing.Point(159, 282);
			this.txtsifre.Name = "txtsifre";
			this.txtsifre.PasswordChar = '*';
			this.txtsifre.Size = new System.Drawing.Size(170, 20);
			this.txtsifre.TabIndex = 11;
			// 
			// txtkadi
			// 
			this.txtkadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtkadi.Location = new System.Drawing.Point(159, 240);
			this.txtkadi.Name = "txtkadi";
			this.txtkadi.Size = new System.Drawing.Size(170, 20);
			this.txtkadi.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(72, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(219, 79);
			this.label3.TabIndex = 12;
			this.label3.Text = "Personel Bilgileri Güncelleme";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(162, 465);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(128, 51);
			this.btnGuncelle.TabIndex = 16;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// Ayarlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(383, 552);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtsifre);
			this.Controls.Add(this.txtkadi);
			this.Name = "Ayarlar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ayarlar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtsifre;
		private System.Windows.Forms.TextBox txtkadi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnGuncelle;
	}
}