namespace OtelKayitSistemi
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.btngiris = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtsifre = new System.Windows.Forms.TextBox();
			this.txtkadi = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.Crimson;
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox3.ForeColor = System.Drawing.SystemColors.Info;
			this.textBox3.Location = new System.Drawing.Point(91, 12);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(227, 22);
			this.textBox3.TabIndex = 11;
			this.textBox3.Text = "İncirkuş Oteline Hoşgeldiniz !!!  İyi Tatiller Dileriz !!!  ";
			// 
			// btngiris
			// 
			this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btngiris.Image = ((System.Drawing.Image)(resources.GetObject("btngiris.Image")));
			this.btngiris.Location = new System.Drawing.Point(123, 271);
			this.btngiris.Name = "btngiris";
			this.btngiris.Size = new System.Drawing.Size(144, 51);
			this.btngiris.TabIndex = 10;
			this.btngiris.UseVisualStyleBackColor = true;
			this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(106, 215);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "Parola :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(106, 173);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Kullanıcı Adı :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtsifre
			// 
			this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtsifre.Location = new System.Drawing.Point(218, 215);
			this.txtsifre.Name = "txtsifre";
			this.txtsifre.PasswordChar = '*';
			this.txtsifre.Size = new System.Drawing.Size(100, 20);
			this.txtsifre.TabIndex = 7;
			// 
			// txtkadi
			// 
			this.txtkadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtkadi.Location = new System.Drawing.Point(218, 173);
			this.txtkadi.Name = "txtkadi";
			this.txtkadi.Size = new System.Drawing.Size(100, 20);
			this.txtkadi.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::OtelKayitSistemi.Properties.Resources.htl;
			this.ClientSize = new System.Drawing.Size(442, 408);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.btngiris);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtsifre);
			this.Controls.Add(this.txtkadi);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Otel Kayıt Sistemi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button btngiris;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtsifre;
		private System.Windows.Forms.TextBox txtkadi;
	}
}

