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

namespace Warser
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.Source = new Uri("https://www.google.com");
        }
    }
}
