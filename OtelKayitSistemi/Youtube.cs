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

namespace OtelKayitSistemi
{
	public partial class Youtube : Form
	{
		public Youtube()
		{
			InitializeComponent();
		}

		private void Youtube_Load(object sender, EventArgs e)
		{
			ChromiumWebBrowser browser = new ChromiumWebBrowser("www.youtube.com");
			this.Controls.Add(browser);
			browser.Dock = DockStyle.Fill;
		}
	}
}
