namespace Warser
{
    partial class Main
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            btn_search = new Button();
            gB_top = new GroupBox();
            btn_refresh = new Button();
            btn_forward = new Button();
            btn_back = new Button();
            txt_search = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            gB_webview = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            gB_top.SuspendLayout();
            gB_webview.SuspendLayout();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(3, 23);
            webView21.Name = "webView21";
            webView21.Size = new Size(1035, 411);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // btn_search
            // 
            btn_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_search.AutoSize = true;
            btn_search.Location = new Point(681, 11);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(134, 30);
            btn_search.TabIndex = 2;
            btn_search.Text = "search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += button1_Click;
            // 
            // gB_top
            // 
            gB_top.BackColor = SystemColors.Highlight;
            gB_top.Controls.Add(btn_refresh);
            gB_top.Controls.Add(btn_forward);
            gB_top.Controls.Add(btn_back);
            gB_top.Controls.Add(txt_search);
            gB_top.Controls.Add(btn_search);
            gB_top.Dock = DockStyle.Top;
            gB_top.Location = new Point(0, 0);
            gB_top.Name = "gB_top";
            gB_top.Size = new Size(1041, 102);
            gB_top.TabIndex = 4;
            gB_top.TabStop = false;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(158, 12);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(68, 29);
            btn_refresh.TabIndex = 6;
            btn_refresh.Text = "refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_forward
            // 
            btn_forward.Location = new Point(78, 11);
            btn_forward.Name = "btn_forward";
            btn_forward.Size = new Size(74, 29);
            btn_forward.TabIndex = 5;
            btn_forward.Text = "forward";
            btn_forward.UseVisualStyleBackColor = true;
            btn_forward.Click += btn_forward_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 11);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(60, 29);
            btn_back.TabIndex = 4;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // txt_search
            // 
            txt_search.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_search.Location = new Point(279, 12);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(396, 27);
            txt_search.TabIndex = 3;
            txt_search.KeyDown += txt_search_KeyDown;
            // 
            // gB_webview
            // 
            gB_webview.BackColor = SystemColors.ActiveBorder;
            gB_webview.Controls.Add(webView21);
            gB_webview.Dock = DockStyle.Fill;
            gB_webview.Location = new Point(0, 102);
            gB_webview.Name = "gB_webview";
            gB_webview.Size = new Size(1041, 437);
            gB_webview.TabIndex = 5;
            gB_webview.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(1041, 539);
            Controls.Add(gB_webview);
            Controls.Add(gB_top);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            gB_top.ResumeLayout(false);
            gB_top.PerformLayout();
            gB_webview.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btn_search;
        private GroupBox gB_top;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox gB_webview;
        private TextBox txt_search;
        private Button btn_back;
        private Button btn_forward;
        private Button btn_refresh;
    }
}