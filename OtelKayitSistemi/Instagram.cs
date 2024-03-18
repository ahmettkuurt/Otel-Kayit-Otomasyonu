using CefSharp;
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
	public partial class Instagram : Form
	{
		public Instagram()
		{
			InitializeComponent();
		}
		ChromiumWebBrowser browser;

		private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
		{
			
		}

		private void Youtube_Load(object sender, EventArgs e)
		{
			ChromiumWebBrowser browser = new ChromiumWebBrowser("www.instagram.com");
			this.Controls.Add(browser);
			browser.Dock = DockStyle.Fill;
		}
	}
}
