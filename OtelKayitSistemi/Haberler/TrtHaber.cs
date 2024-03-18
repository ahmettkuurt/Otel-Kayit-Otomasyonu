using CefSharp.WinForms;
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
	public partial class TrtHaber : Form
	{
		public TrtHaber()
		{
			InitializeComponent();
		}

		private void TrtHaber_Load(object sender, EventArgs e)
		{
			ChromiumWebBrowser browser = new ChromiumWebBrowser("www.trthaber.com");
			this.Controls.Add(browser);
			browser.Dock = DockStyle.Fill;
		}
	}
}
