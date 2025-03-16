using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using static System.Windows.Forms.DataFormats;

namespace Warser
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitializeWebView();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;

            //this.TopMost = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.Source = new Uri("https://www.google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchQuery = txt_search.Text;

            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                if (!searchQuery.Contains("."))
                {
                    webView21.Source = new Uri("https://www.google.com/search?q=" + Uri.EscapeDataString(searchQuery));
                }
                else
                {
                    if (!searchQuery.StartsWith("http"))
                    {
                        searchQuery = "https://" + searchQuery;
                    }
                    webView21.Source = new Uri(searchQuery);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoBack) webView21.GoBack();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoForward) webView21.GoForward();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
