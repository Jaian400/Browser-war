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

            //this.TopMost = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {


        }
        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.Source = new Uri("https://www.pornhub.com");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
