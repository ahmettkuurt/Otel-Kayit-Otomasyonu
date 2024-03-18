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
	public partial class Milliyet : Form
	{
		public Milliyet()
		{
			InitializeComponent();
		}

		private void Milliyet_Load(object sender, EventArgs e)
		{
			ChromiumWebBrowser browser = new ChromiumWebBrowser("www.milliyet.com");
			this.Controls.Add(browser);
			browser.Dock = DockStyle.Fill;
		}
	}
}
